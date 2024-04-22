using MediatR;
using RepositoryPattern.Models;

namespace RepositoryPattern.Implementations.Commands.DeleteStudent
{
    public record  DeleteStudentCommand(Student Student):IRequest<bool>
    {
    }
}
