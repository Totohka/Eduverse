using Eduverse.Model.Entities.Bases;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Transactions;

namespace Eduverse.BL.Services.Contracts
{
    public interface IBaseService<T> where T : BaseEntity
    {
        public Task CreateAsync(T entity);
        public Task UpdateAsync(T entity);
        public Task DeleteAsync(Guid uid);
        public Task<T?> GetEntityAsync(Guid uid);
        public Task<T?> GetEntityAsync(Expression<Func<T, bool>> predicate);
        public Task<T?> GetFirstEntityAsync<TKey>(Expression<Func<T, TKey>> order);
        public Task<T?> GetLastEntityAsync<TKey>(Expression<Func<T, TKey>> order);
        public Task<List<T?>> GetAllEntitiesAsync();
        public Task<List<T?>> GetAllEntitiesAsync(Expression<Func<T, bool>> predicate);
        public Task<List<T>?> GetAllEntitiesAsync<TProperty>(Expression<Func<T, bool>> predicate, params Expression<Func<T, TProperty>>[] includes);
        public Task<List<T>?> GetAllEntitiesOrderAsync<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc);
        public Task<List<T>?> GetAllEntitiesOrderAsync<TKey, TProperty>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc, params Expression<Func<T, TProperty>>[] includes);
        public Task<List<T>?> GetPageAsync(int take, int skip);
        public Task<List<T>?> GetPageAsync(Expression<Func<T, bool>> predicate, int take, int skip);
        public Task<List<T>?> GetPageAsync<TProperty>(Expression<Func<T, bool>> predicate, int take, int skip, params Expression<Func<T, TProperty>>[] includes);
        public Task<List<T>?> GetPageOrderAsync<TKey>(Expression<Func<T, TKey>> order, bool asc, int take, int skip);
        public Task<List<T>?> GetPageOrderAsync<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc, int take, int skip);
        public Task<List<T>?> GetPageOrderAsync<TKey, TProperty>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc, int take, int skip, params Expression<Func<T, TProperty>>[] includes);
    }
}
