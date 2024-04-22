using MediatR;
using RepositoryPattern.Models;

namespace RepositoryPattern.Implementations.Queries.GetStudent
{
    public record GetStudentQuery(int Id) : IRequest<Student>
    {
    }
}
