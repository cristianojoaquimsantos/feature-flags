using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using FeatureFlags.Domain.Core;
using FeatureFlags.Domain.Repository.Interface;
using FeatureFlags.Infra.Data.Context;

namespace FeatureFlags.Infra.Data.Repository
{
    [ExcludeFromCodeCoverage]
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : Entity
    {
        protected readonly FeatureFlagContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        private bool disposed = false;        

        public RepositoryBase(FeatureFlagContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~RepositoryBase() { Dispose(false); }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                disposed = true;
            }
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity?> GetById(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Remove(Guid id)
        {
            TEntity? obj = GetById(id).Result;
            _dbSet.Remove(obj);
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _dbSet.Update(entity);
        }
    }
}
