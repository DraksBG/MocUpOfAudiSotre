namespace MocUpOfAudiStore.Data.Common.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore.Metadata;

    public interface IRepository<TEntity> : IDisposable
        where TEntity : class
    {
        IQueryable<TEntity> All();

        IQueryable<TEntity> AllAsNoTracking();

        Task AddAsync(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        Task<int> SaveChangesAsync();

        void Add(TEntity entity);

        void AddRange(params TEntity[] entities);

        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);

        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        IEntityType FindEntityType(Type type);

        Task<TEntity> GetByIdAsync(params object[] keyValues);

        IQueryable<TEntity> GetAll();

        Task RemoveRangeWhereAsync(Expression<Func<TEntity, bool>> predicate);

        Task<int> CompleteAsync();
    }
}
