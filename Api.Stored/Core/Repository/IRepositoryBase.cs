using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Api.Stored.Core.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<List<T>> FindAll(Expression<Func<T, object>> order, params Expression<Func<T, object>>[] includes);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes);
        Task<T> FindBy(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
