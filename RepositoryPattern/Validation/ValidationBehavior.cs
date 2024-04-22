﻿using FluentValidation;
using MediatR;
using System;
using System.Windows.Input;

namespace RepositoryPattern.Validation
{
    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest :  IRequest<TResponse>
  
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationBehavior{TRequest,TResponse}"/> class.
        /// </summary>
        /// <param name="validators">The validator for the current request type.</param>
        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (!_validators.Any())
            {
                return await next();
            }

            var context = new ValidationContext<TRequest>(request);

            var failures = _validators
                .Select(v => v.Validate(context))
                .SelectMany(result => result.Errors)
                .Where(f => f != null)
                .ToList();

            if (failures.Count != 0)
            {
                throw new ValidationException(failures);
            }

            return await next();
        }

        //public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        //{
        //    if (!_validators.Any())
        //    {
        //        return await next();
        //    }

        //    var context = new ValidationContext<TRequest>(request);

        //    var failures = _validators
        //        .Select(v => v.Validate(context))
        //        .SelectMany(result => result.Errors)
        //        .Where(f => f != null)
        //        .ToList();

        //    if (failures.Count != 0)
        //    {
        //        throw new ValidationException(failures);
        //    }

        //    return await next();
        //}
    }
}