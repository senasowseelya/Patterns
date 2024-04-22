using MediatR;
using RepositoryPattern.Services;

namespace RepositoryPattern.Implementations.Commands.UpdateStudent
{
    public class UpdateStudentCommandHandler(IStudentContract studentService) : IRequestHandler<UpdateStudentCommand, bool>
    {
        private readonly IStudentContract studentService = studentService;

        public Task<bool> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(studentService.Update(request.Student));
        }
    }
}
