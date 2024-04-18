using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Models;
using RepositoryPattern.Services;

namespace RepositoryPattern.Controllers
{
    [ApiController]
    [Route("Department")]
    public class DepartmentController
    {
        private readonly IDepartmentContract departmentService;

        public DepartmentController(IDepartmentContract departmentService)
        {
            this.departmentService = departmentService;
        }
        [HttpGet]
        public IEnumerable<Department> Get()
        {
            return departmentService.GetAll();
        }

        [HttpPost]
        public bool Post([FromBody]Department department)
        {
            return departmentService.CreateDepartment(department);
        }
    }
}
