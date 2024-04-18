using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using RepositoryPattern.Models;


namespace RepositoryPattern
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Student> Student { get; set; }
        public ApplicationDbContext()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(new Department { Id = 1, Name = "CSE", Description = "ABC" });
            modelBuilder.Entity<Department>().HasData(new Department { Id = 2, Name = "ECE", Description = "ABC" });
            modelBuilder.Entity<Department>().HasData(new Department { Id = 3, Name = "EEE", Description = "ABC" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 1, Name = "Me", Age = 23, DepartmentId = 1 });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 2, Name = "Ram", Age = 23, DepartmentId = 2 });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 3, Name = "Sita", Age = 23, DepartmentId = 1 });

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PatternsRelearn;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }
    }
}