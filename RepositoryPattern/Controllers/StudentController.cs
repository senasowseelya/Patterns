using MediatR;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Implementations.Commands.CreateStudent;
using RepositoryPattern.Implementations.Commands.DeleteStudent;
using RepositoryPattern.Implementations.Commands.UpdateStudent;
using RepositoryPattern.Implementations.Queries.GetStudent;
using RepositoryPattern.Implementations.Queries.GetStudents;
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
        private readonly IMediator mediator;

        public StudentController(IStudentContract _studentService,IMediator mediator)
        {
            this._studentService = _studentService;
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<Student> GetStudent(int id)
        {
             return await mediator.Send(new GetStudentQuery(id));
        }

        [HttpGet("all")]
        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await mediator.Send(new GetStudentsQuery());
            
        }

        [HttpDelete]
        public async Task<bool> DeleteStudent(Student student)
        {
            return await mediator.Send(new DeleteStudentCommand(student));
        }

        [HttpPost]
        public async Task<bool> CreateStudent(Student student)
        {
          return await mediator.Send(new CreateStudentCommand(student));
        }

        [HttpPut]
        public async Task<bool> UpdateStudent(Student student)
        {
            return await mediator.Send(new UpdateStudentCommand(student));
        }




    }
}
