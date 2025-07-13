using Eduverse.DAL.Repositories.Contracts.Bases;
using Eduverse.Model.Entities.Bases;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Eduverse.DAL.Repositories.Implement.Bases
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : BaseEntity
    {
        #region Contructor

        protected readonly EduverseContext _context;
        public BaseRepository(EduverseContext context)
        {
            _context = context;
        }

        #endregion

        #region Create
        public virtual async Task CreateAsync(T item)
        {
            await _context.Set<T>().AddAsync(item);
            await _context.SaveChangesAsync();
        }
        #endregion

        #region Delete
        public virtual async Task DeleteAsync(Guid uid)
        {
            T item = await _context.Set<T>().FindAsync(uid);
            _context.Set<T>().Remove(item);
            await _context.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            List<T> items = await _context.Set<T>().AsNoTracking().Where(predicate).ToListAsync();
            foreach (T item in items)
            {
                _context.Set<T>().Remove(item);
            }
            await _context.SaveChangesAsync();
        }

        public async Task ExecStoredProc(string name)
        {
            await _context.Database.ExecuteSqlAsync($"EXEC dbo.{name}");
        }
        #endregion

        #region GetAll
        public virtual async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public virtual async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().AsNoTracking().Where(predicate).ToListAsync();
        }

        public async Task<List<T>> GetAllAsync<TProperty>(Expression<Func<T, bool>> predicate, params Expression<Func<T, TProperty>>[] includes)
        {
            IQueryable<T> query = _context.Set<T>().AsNoTracking().Where(predicate);
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.ToListAsync();
        }

        public virtual async Task<List<T>> GetAllOrderAsync<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc)
        {
            if (asc)
                return await _context.Set<T>().AsNoTracking().OrderBy(order).Where(predicate).ToListAsync();
            else 
                return await _context.Set<T>().AsNoTracking().OrderByDescending(order).Where(predicate).ToListAsync();
        }

        public async Task<List<T>> GetAllOrderAsync<TKey, TProperty>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc, params Expression<Func<T, TProperty>>[] includes)
        {
            IQueryable<T> query = null;
            if (asc)
                query = _context.Set<T>().AsNoTracking().OrderBy(order).Where(predicate);
            else
                query = _context.Set<T>().AsNoTracking().OrderByDescending(order).Where(predicate);

            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.ToListAsync();
        }

        #endregion

        #region Get
        public virtual async Task<T> GetAsync(Guid uid)
        {
            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(t => t.Uid == uid);
        }
        public virtual async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(predicate);
        }

        public virtual async Task<T> GetFirstAsync<TKey>(Expression<Func<T, TKey>> order)
        {
            return await _context.Set<T>().AsNoTracking().OrderBy(order).FirstAsync();
        }

        public virtual async Task<T> GetLastAsync<TKey>(Expression<Func<T, TKey>> order)
        {
            return await _context.Set<T>().AsNoTracking().OrderByDescending(order).LastAsync();
        }

        #endregion

        #region GetPage

        public virtual async Task<List<T>> GetPageAsync(int take, int skip)
        {
            return await _context.Set<T>().AsNoTracking().Skip(skip).Take(take).ToListAsync();
        }

        public virtual async Task<List<T>> GetPageAsync(Expression<Func<T, bool>> predicate, int take, int skip)
        {
            return await _context.Set<T>().AsNoTracking().Where(predicate).Skip(skip).Take(take).ToListAsync();
        }

        public async Task<List<T>> GetPageAsync<TProperty>(Expression<Func<T, bool>> predicate, int take, int skip, params Expression<Func<T, TProperty>>[] includes)
        {
            IQueryable<T> query = _context.Set<T>().AsNoTracking().Where(predicate).Skip(skip).Take(take);

            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.ToListAsync();
        }

        public virtual async Task<List<T>> GetPageOrderAsync<TKey>(Expression<Func<T, TKey>> order, bool asc, int take, int skip)
        {
            if (asc)
                return await _context.Set<T>().AsNoTracking().OrderBy(order).Skip(skip).Take(take).ToListAsync();
            else
                return await _context.Set<T>().AsNoTracking().OrderByDescending(order).Skip(skip).Take(take).ToListAsync();
        }

        public virtual async Task<List<T>> GetPageOrderAsync<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc, int take, int skip)
        {
            if (asc)
                return await _context.Set<T>().AsNoTracking().OrderBy(order).Where(predicate).Skip(skip).Take(take).ToListAsync();
            else
                return await _context.Set<T>().AsNoTracking().OrderByDescending(order).Where(predicate).Skip(skip).Take(take).ToListAsync();
        }

        public async Task<List<T>> GetPageOrderAsync<TKey, TProperty>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc, int take, int skip, params Expression<Func<T, TProperty>>[] includes)
        {
            IQueryable<T> query = null;
            if (asc)
                query = _context.Set<T>().AsNoTracking().OrderBy(order).Where(predicate).Skip(skip).Take(take);
            else
                query = _context.Set<T>().AsNoTracking().OrderByDescending(order).Where(predicate).Skip(skip).Take(take);

            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.ToListAsync();
        }

        #endregion

        #region Update
        public virtual async Task UpdateAsync(T item)
        {
            _context.Set<T>().Update(item);
            await _context.SaveChangesAsync();
        }
        #endregion
    }
}
