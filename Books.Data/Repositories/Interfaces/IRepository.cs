using Books.Data.Entities;

namespace Books.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        IQueryable<T> All { get; }

        Task<T> Find(int id);

        void Insert(T entity);

        void Update(T entity);

        void Delete(int id);
    }
}
