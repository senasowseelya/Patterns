using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Models;

namespace RepositoryPattern.Repositories
{
    public class EFDepartmentRepository : EFRepository<Department>, IDepartmentRepository
    {
        public EFDepartmentRepository(ApplicationDbContext context):base(context)
        {
                
        }
    }
}
