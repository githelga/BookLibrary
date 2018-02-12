using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BookLibrary.Models.Common;

namespace BookLibrary.Store.Core
{
    public interface IEntityRepository<T> where T : IBaseEntity
    {
        Task<IEnumerable<T>> Get();
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        Task<IEnumerable<T>> Get(int page, int pageSize, Expression<Func<T, bool>> predicate);
        Task<T> Single(Expression<Func<T, bool>> predicate);
        Task<T> Single(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        Task<object> Add(T item);
        Task<object> Add(IEnumerable<T> items);
        Task<object> Update(T item);
        Task<object> Remove(T item);
        Task<object> Remove(Expression<Func<T, bool>> predicate);
        Task<object> Commit();
    }
}