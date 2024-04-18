using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Models;

namespace RepositoryPattern.Repositories
{
    public class EFStudentRepository : EFRepository<Student>, IStudentRepository
    {
        public EFStudentRepository(ApplicationDbContext context) : base(context) { }




    }
}
