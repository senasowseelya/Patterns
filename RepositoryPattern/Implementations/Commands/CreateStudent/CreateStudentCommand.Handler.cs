using FluentValidation;
using MediatR;
using RepositoryPattern.Models;
using RepositoryPattern.Services;

namespace RepositoryPattern.Implementations.Commands.CreateStudent
{
    public class CreateStudentCommandHandler(IStudentContract studentService) : IRequestHandler<CreateStudentCommand, bool>
    {
        private readonly IStudentContract studentService = studentService;

        public async Task<bool> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
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
