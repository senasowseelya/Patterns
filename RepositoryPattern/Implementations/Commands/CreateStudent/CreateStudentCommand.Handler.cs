using MediatR;
using RepositoryPattern.Services;

namespace RepositoryPattern.Implementations.Commands.CreateStudent
{
    public class CreateStudentCommandHandler(IStudentContract studentService) : IRequestHandler<CreateStudentCommand, bool>
    {
        private readonly IStudentContract studentService = studentService;

        public async Task<bool> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
           return await Task.FromResult(studentService.Create(request.student));
        }
    }
}
