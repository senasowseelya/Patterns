using MediatR;
using RepositoryPattern.Models;

namespace RepositoryPattern.Implementations.Commands.UpdateStudent
{
    public record UpdateStudentCommand(Student Student):IRequest<bool>
    {
    }
}
