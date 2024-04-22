using FluentValidation;
using RepositoryPattern.Implementations.Commands.CreateStudent;

namespace RepositoryPattern.Validation
{
    public class CreateStudentCommandValidator : AbstractValidator<CreateStudentCommand>
    {
        public CreateStudentCommandValidator()
        {
            RuleFor(command => command.Name).NotNull().WithMessage("Student Name should not be null");
            RuleFor(command => command.Age).NotNull().WithMessage("Student Age should not be null");
            RuleFor(command => command.DepartmentId).NotNull().WithMessage("Student Department should not be null");
            RuleFor(command => command.DepartmentId).NotEqual(10).WithMessage("Student Department cannot be 10");
        }
    }
}

