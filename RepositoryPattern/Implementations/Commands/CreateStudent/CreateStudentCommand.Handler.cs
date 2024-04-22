using FluentValidation;
using MediatR;
using RepositoryPattern.Models;
using RepositoryPattern.Services;

namespace RepositoryPattern.Implementations.Commands.CreateStudent
{
    public class CreateStudentCommandHandler(IStudentContract studentService, IValidator<CreateStudentCommand> validator) : IRequestHandler<CreateStudentCommand, bool>
    {
        private readonly IStudentContract studentService = studentService;
        private readonly IValidator<CreateStudentCommand> validator = validator;

        public async Task<bool> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var result = validator.Validate(request);
            if (!result.IsValid)
            {
                foreach (var failure in result.Errors) {
                    Console.WriteLine($"Property: {failure.PropertyName} Error Code: {failure.ErrorCode}");
                }
            }
            Student student = new()
            {
                Name = request.Name,
                Age = request.Age,
                DOB = request.DOB,
                DepartmentId = request.DepartmentId
            };
           return await Task.FromResult(studentService.Create(student));
        }
    }
}
