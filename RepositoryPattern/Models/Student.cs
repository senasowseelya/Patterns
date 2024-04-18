namespace RepositoryPattern.Models
{
    public class Student:BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set;}
        public Department Department { get; set;}
        public int DepartmentId { get; set;}
    }
}
