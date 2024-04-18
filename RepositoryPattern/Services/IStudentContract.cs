using RepositoryPattern.Models;
using RepositoryPattern.Repositories;

namespace RepositoryPattern.Services
{
    public interface IStudentContract
    {
        public bool Create(Student entity);
        public bool Delete(Student entity);
        public IEnumerable<Student> GetAll();

        public Student GetById(int Id);
        public bool Update(Student entity);
       
    }
}
