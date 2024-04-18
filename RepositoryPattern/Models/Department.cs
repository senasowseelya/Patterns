namespace RepositoryPattern.Models
{
    public class Department :BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //public List<Student> Students { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
