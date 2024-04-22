using MediatR;
using RepositoryPattern.Models;
using RepositoryPattern.Services;

namespace RepositoryPattern.Implementations.Queries.GetStudents
{
    public class GetStudentsQueryHandler(IStudentContract studentService) : IRequestHandler<GetStudentsQuery, IEnumerable<Student>>
    {
        private IStudentContract _studentService = studentService;

        public Task<IEnumerable<Student>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_studentService.GetAll());
        }
    }
}
