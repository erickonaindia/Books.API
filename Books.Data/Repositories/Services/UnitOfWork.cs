using Microsoft.EntityFrameworkCore;
using Books.Data.Entities;
using Books.Data.Repositories.Interfaces;

namespace Books.Data.Repositories.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _context { get; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void SetModified<T>(T entity) where T : EntityBase
        {
            GetSet<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public DbSet<T> GetSet<T>() where T : EntityBase
        {
            return _context.Set<T>();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
