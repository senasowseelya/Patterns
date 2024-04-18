using RepositoryPattern.Repositories;

namespace RepositoryPattern
{
    public class UnitOfWork :IUnitOfWork,IDisposable
    {
        public ApplicationDbContext context = new ApplicationDbContext();
        //private EFStudentRepository studentRepository;
        //private EFDepartmentRepository departmentRepository;
        //public EFStudentRepository StudentRepository {
        //    get
        //    {
        //        if (StudentRepository is null)
        //        {
        //            studentRepository = new EFStudentRepository(context);
        //        }
        //        return studentRepository;
        //    }
        //    set
        //    {
        //        studentRepository = value;
        //    }
        //}
        //public EFDepartmentRepository DepartmentRepository
        //{
        //    get
        //    {
        //        if(departmentRepository is null)
        //        {
        //            departmentRepository = new EFDepartmentRepository(context);
        //        }
        //        return departmentRepository;
        //    }
        //    set
        //    {
        //        departmentRepository = value;
        //    }
        //}

        public UnitOfWork()
        {
            StudentRepository = new EFStudentRepository(context);
            DepartmentRepository = new EFDepartmentRepository(context);
        }



        private bool disposed = false;

        public EFStudentRepository StudentRepository { get; set; }
        public  EFDepartmentRepository DepartmentRepository { get;  }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            context.SaveChanges();
        }

      
    }
}
