using MediatR;
using RepositoryPattern.Models;
using RepositoryPattern.Services;

namespace RepositoryPattern.Implementations.Queries.GetStudent
{
    public class GetStudentQueryHandler(IStudentContract studentContract) : IRequestHandler<GetStudentQuery, Student>
    {
        private readonly IStudentContract studentContract = studentContract;

        public Task<Student> Handle(GetStudentQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(studentContract.GetById(request.Id   ));
        }
    }
}
