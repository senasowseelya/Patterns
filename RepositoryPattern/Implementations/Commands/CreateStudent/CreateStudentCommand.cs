using MediatR;
using RepositoryPattern.Models;

namespace RepositoryPattern.Implementations.Commands.CreateStudent
{
    public record CreateStudentCommand(Student student):IRequest<bool>
    {
    }
}
