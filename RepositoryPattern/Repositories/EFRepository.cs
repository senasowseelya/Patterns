
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Models;

namespace RepositoryPattern.Repositories
{
    public class EFRepository<T> : IRepository<T> where T: BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;
        public EFRepository(ApplicationDbContext dbContext) {
            _context = dbContext;
            _dbSet = _context.Set<T>();
        }
        public bool Create(T entity)
        {
            _dbSet.Add(entity);
            return true;
        }

        public bool Delete(T entity)
        {
            _dbSet.Remove(entity);
            return true;
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int Id)
        {
            return _dbSet.Find(Id);
        }

        public bool Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return true;
        }
    }
}
