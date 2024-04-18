using RepositoryPattern.Models;
using RepositoryPattern.Repositories;

namespace RepositoryPattern.Services
{
    public class StudentService :IStudentContract
    {
        private readonly IUnitOfWork unitOfWork;

        public StudentService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
       

        public bool Create(Student entity)
        {
            bool isuccess = unitOfWork.StudentRepository.Create(entity);
            unitOfWork.Save();
            return isuccess;
        }

        public bool Delete(Student entity)
        {
            bool isuccess = unitOfWork.StudentRepository.Delete(entity);
            unitOfWork.Save();
            return isuccess;
        }

        public IEnumerable<Student> GetAll()
        {
            return unitOfWork.StudentRepository.GetAll();
        }

        public Student GetById(int Id)
        {
            return unitOfWork.StudentRepository.GetById(Id);
        }

        public bool Update(Student entity)
        {
            bool isuccess = unitOfWork.StudentRepository.Update(entity);
            unitOfWork.Save();
            return isuccess;
        }
    }
}
