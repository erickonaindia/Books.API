using Microsoft.EntityFrameworkCore;
using Books.Data.Entities;

namespace Books.Data.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();

        Task CommitAsync();

        void SetModified<T>(T entity) where T : EntityBase;

        DbSet<T> GetSet<T>() where T : EntityBase;
    }
}
