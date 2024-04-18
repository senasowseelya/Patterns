using RepositoryPattern.Models;
using System.Data;
using System.Runtime.InteropServices;

namespace RepositoryPattern.Repositories
{
    public interface IRepository<T> 
    {
        IEnumerable<T>GetAll();
        T GetById(int Id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);

    }
}
