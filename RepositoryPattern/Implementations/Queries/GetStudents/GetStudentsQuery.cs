using MediatR;
using RepositoryPattern.Models;

namespace RepositoryPattern.Implementations.Queries.GetStudents
{
    public class GetStudentsQuery : IRequest<IEnumerable<Student>>
    {
    }
}
