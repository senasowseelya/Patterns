
using RepositoryPattern.Models;
namespace RepositoryPattern.Repositories
{
    

    public class StudentRepository :IStudentRepository
    {
        public List<Student> Students { get; set; }
        public StudentRepository()
        {

            Students = new List<Student>
        {
            new Student { Age=10,Name="ABC",Id=1},
            new Student { Age=11,Name="DEf",Id=2},
            new Student { Age=13,Name="GHI",Id=4},
            new Student { Age=14,Name="JKL",Id=3}
        };
        }

        public IEnumerable<Student> GetAll()
        {
            return Students;
        }

        public Student GetById(int Id)
        {
            return Students.FirstOrDefault(x => x.Id == Id);
        }

        public bool Create(Student student)
        {
            Students.Add(student);
            foreach (var item in Students)
            {
                Console.WriteLine("From student service" + item.Id);
            }
            return true;
        }

        public bool Update(Student student)
        {
            var x = Students.FirstOrDefault(x => x.Id == student.Id);
            x.Name = student.Name;
            return true;
        }

        public bool Delete(Student student)
        {
            Students.Remove(student);
            return true;
        }
    }
}
