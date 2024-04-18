using RepositoryPattern.Models;
using RepositoryPattern.Repositories;

namespace RepositoryPattern
{
    public interface IUnitOfWork
    {
        public EFStudentRepository StudentRepository { get;  }
        public EFDepartmentRepository DepartmentRepository { get;  }
        void Save();
    }
}
