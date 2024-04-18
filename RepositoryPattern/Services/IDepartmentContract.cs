using RepositoryPattern.Models;

namespace RepositoryPattern.Services
{
    public interface IDepartmentContract
    {
        IEnumerable<Department> GetAll();
        bool CreateDepartment(Department department);
    }
}
