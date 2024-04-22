using MediatR;
using RepositoryPattern.Implementations.Commands.UpdateStudent;
using RepositoryPattern.Services;

namespace RepositoryPattern.Implementations.Commands.DeleteStudent
{
    public class DeleteStudentCommandHandler(IStudentContract studentService) : IRequestHandler<DeleteStudentCommand, bool>
    {
        private readonly IStudentContract studentService = studentService;

        public Task<bool> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(studentService.Delete(request.Student));
        }
    }
}
