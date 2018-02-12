using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BookLibrary.Models.Common;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Store.Core
{
    public abstract class EntityRepository<T> : IEntityRepository<T> where T : BaseEntity
    {
        private readonly IDbContext _context;

        protected EntityRepository(IDbFactory factory)
        {
            _context = factory.GetDb;
        }

        public virtual async Task<object> Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            _context.Set<T>().Add(item);
            return await Commit();
        }

        public virtual async Task<object> Add(IEnumerable<T> items)
        {
            if (items == null)
                throw new ArgumentNullException(nameof(items));

            _context.Set<T>().AddRange(items);
            return await Commit();
        }

        public async Task<object> Commit()
        {
            return await _context.SaveChangesAsync();
        }

        public virtual async Task<IEnumerable<T>> Get()
        {
            return await Query().ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            var query = includeProperties.Aggregate(Query(), (current, includeProperty) => current.Include(includeProperty));
            return await query.Where(predicate).ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> Get(int page, int pageSize, Expression<Func<T, bool>> predicate)
        {
            return await Query().Skip((page - 1) * pageSize).Take(pageSize).Where(predicate).ToListAsync();
        }

        public virtual async Task<object> Remove(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            _context.Set<T>().Remove(item);
            return await Commit();
        }

        public virtual async Task<object> Remove(Expression<Func<T, bool>> predicate)
        {
            try
            {
                var entities = Query().Where(predicate);
                foreach (var entity in entities)
                    _context.Entry(entity).State = EntityState.Deleted;
                return await Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual async Task<T> Single(Expression<Func<T, bool>> predicate)
        {
            return await Query().FirstOrDefaultAsync(predicate);
        }

        public virtual async Task<T> Single(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            var query = includeProperties.Aggregate(Query(), (current, includeProperty) => current.Include(includeProperty));
            return await query.Where(predicate).FirstOrDefaultAsync();
        }

        public virtual async Task<object> Update(T item)
        {
            try
            {
                if (item == null)
                    throw new ArgumentNullException(nameof(item));

                var entry = _context.Entry(item);
                _context.Set<T>().Attach(item);
                entry.State = EntityState.Modified;
                return await Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private IQueryable<T> Query()
        {
            return _context.Set<T>();
        }
    }
}