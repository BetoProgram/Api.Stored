using Api.Stored.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Api.Stored.Core.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly StoredAppDbContext _storedDbContext;

        public RepositoryBase(StoredAppDbContext storedDbContext)
        {
            _storedDbContext = storedDbContext;
        }
        public async Task<List<T>> FindAll(Expression<Func<T, object>> order = null,params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _storedDbContext.Set<T>();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.AsNoTracking().OrderBy(order).Select(x => x).ToListAsync();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _storedDbContext.Set<T>();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return query.AsNoTracking().Where(expression).Select(x => x);
        }

        public async Task CreateAsync(T entity)
        {
            _storedDbContext.Set<T>().Add(entity);
            await _storedDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _storedDbContext.Set<T>().Remove(entity);
            await _storedDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _storedDbContext.Set<T>().Update(entity);
            await _storedDbContext.SaveChangesAsync();
        }

        public async Task<T> FindBy(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _storedDbContext.Set<T>();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }
    }
}
