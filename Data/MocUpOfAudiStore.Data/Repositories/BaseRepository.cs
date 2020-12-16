﻿namespace MocUpOfAudiStore.Data.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata;
    using MocUpOfAudiStore.Data.Common.Repositories;

#pragma warning disable CA1063 // Implement IDisposable Correctly
    public abstract class BaseRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private DbContext dbContext;

        public BaseRepository(DbContext dbContext) => this.dbContext = dbContext;

        public void Add(TEntity entity)
        {
            this.dbContext.Set<TEntity>().Add(entity);
        }

        public void AddRange(params TEntity[] entities)
        {
            this.dbContext.Set<TEntity>().AddRange(entities);
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await this.dbContext.Set<TEntity>().AnyAsync(predicate);
        }

        public async Task<int> CountAllAsync()
        {
            var count = await this.dbContext.Set<TEntity>()
                .CountAsync();

            return count;
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var count = await this.dbContext.Set<TEntity>()
                .Where(predicate)
                .CountAsync();

            return count;
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            var result = this.dbContext.Set<TEntity>()
                .Where(predicate);

            return result;
        }

        public IEntityType FindEntityType(Type type)
        {
            return this.dbContext.Model.FindEntityType(type);
        }

        public IQueryable<TEntity> GetAll()
        {
            return this.dbContext.Set<TEntity>();
        }

        public async Task<TEntity> GetByIdAsync(string id)
        {
            return await this.dbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> GetByIdAsync(params object[] keyValues)
        {
            return await this.dbContext.Set<TEntity>().FindAsync(keyValues);
        }

        public void Remove(TEntity entity)
        {
            this.dbContext.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(params TEntity[] entities)
        {
            this.dbContext.Set<TEntity>().RemoveRange(entities);
        }

        public async Task RemoveRangeWhereAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var filtered = await this.dbContext.Set<TEntity>()
                .Where(predicate)
                .ToArrayAsync();
            this.dbContext.RemoveRange(filtered);
        }

        public async Task<int> CompleteAsync()
        {
            return await this.dbContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> All()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> AllAsNoTracking()
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

    }
}
