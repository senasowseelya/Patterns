using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Models;
using RepositoryPattern.Repositories;
using RepositoryPattern.Services;

namespace RepositoryPattern.Controllers
{

    [ApiController]
    [Route("/Student")]
    public class StudentController
    {
        private readonly IStudentContract _studentService;

        public StudentController(IStudentContract _studentService)
        {
            this._studentService = _studentService;
        }

        [HttpGet]
        public Student GetStudent(int id)
        {
            return _studentService.GetById(id);
        }

        [HttpGet("all")]
        public IEnumerable<Student> GetStudents()
        {
            return _studentService.GetAll();
        }

        [HttpDelete]
        public bool DeleteStudent(Student student)
        {
            return _studentService.Delete(student);
        }

        [HttpPost]
        public bool CreateStudent(Student student)
        {
             _studentService.Create(student);
            return true;
        }

        [HttpPut]
        public bool UpdateStudent(Student student)
        {
            return _studentService.Update(student);
        }




    }
}
