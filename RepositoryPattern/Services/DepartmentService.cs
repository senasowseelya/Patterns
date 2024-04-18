using RepositoryPattern.Models;
using RepositoryPattern.Repositories;

namespace RepositoryPattern.Services
{
    public class DepartmentService : IDepartmentContract
    {
        private readonly IUnitOfWork unitOfWork;

        public DepartmentService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public bool CreateDepartment(Department department)
        {
           bool isSuccess = unitOfWork.DepartmentRepository.Create(department);
            unitOfWork.Save();
            return isSuccess;
            
        }

        public IEnumerable<Department> GetAll()
        {
           return unitOfWork.DepartmentRepository.GetAll();
        }
    }
}
