using MediatR;
using RepositoryPattern.Models;

namespace RepositoryPattern.Implementations.Commands.CreateStudent
{
    public record CreateStudentCommand(string? Name, int Age, DateTime DOB, int DepartmentId):IRequest<bool>
    {
    }
}
