using Eduverse.BL.Services.Contracts;
using Eduverse.Managers.Managers.Contracts;
using Eduverse.Model.Entities.Bases;
using System.Linq.Expressions;

namespace Eduverse.BL.Services.Impelements
{
    public class BaseService<T> : IBaseService<T>
        where T : BaseEntity
    {
        private readonly IBaseManager<T> _manager; 
        public BaseService(IBaseManager<T> manager)
        { 
            _manager = manager;
        }
        public async Task CreateAsync(T entity)
        {
            await _manager.CreateAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            await _manager.UpdateAsync(entity);
        }

        public async Task DeleteAsync(Guid uid)
        {
            await _manager.DeleteAsync(uid);
        }

        public async Task<List<T?>> GetAllEntitiesAsync()
        {
            return await _manager.GetAllAsync();
        }
        public async Task<List<T?>> GetAllEntitiesAsync(Expression<Func<T, bool>> predicate)
        {
            return await _manager.GetAllAsync(predicate);
        }

        public async Task<T?> GetEntityAsync(Guid uid)
        {
            return await _manager.GetAsync(uid);
        }

        public async Task<T?> GetEntityAsync(Expression<Func<T, bool>> predicate)
        {
            return await _manager.GetAsync(predicate);
        }

        public async Task<T?> GetFirstEntityAsync<TKey>(Expression<Func<T, TKey>> order)
        {
            return await _manager.GetFirstAsync(order);
        }

        public async Task<T?> GetLastEntityAsync<TKey>(Expression<Func<T, TKey>> order)
        {
            return await _manager.GetLastAsync(order);
        }

        public async Task<List<T>?> GetAllEntitiesAsync<TProperty>(Expression<Func<T, bool>> predicate, params Expression<Func<T, TProperty>>[] includes)
        {
            return await _manager.GetAllAsync(predicate, includes);
        }

        public async Task<List<T>?> GetAllEntitiesOrderAsync<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc)
        {
            return await _manager.GetAllOrderAsync(predicate, order, asc);
        }

        public async Task<List<T>?> GetAllEntitiesOrderAsync<TKey, TProperty>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc, params Expression<Func<T, TProperty>>[] includes)
        {
            return await _manager.GetAllOrderAsync(predicate, order, asc, includes);
        }

        public async Task<List<T>?> GetPageAsync(int take, int skip)
        {
            return await _manager.GetPageAsync(take, skip);
        }

        public async Task<List<T>?> GetPageAsync(Expression<Func<T, bool>> predicate, int take, int skip)
        {
            return await _manager.GetPageAsync(predicate, take, skip);
        }

        public async Task<List<T>?> GetPageAsync<TProperty>(Expression<Func<T, bool>> predicate, int take, int skip, params Expression<Func<T, TProperty>>[] includes)
        {
            return await _manager.GetPageAsync(predicate, take, skip, includes);
        }

        public async Task<List<T>?> GetPageOrderAsync<TKey>(Expression<Func<T, TKey>> order, bool asc, int take, int skip)
        {
            return await _manager.GetPageOrderAsync(order, asc, take, skip);
        }

        public async Task<List<T>?> GetPageOrderAsync<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc, int take, int skip)
        {
            return await _manager.GetPageOrderAsync(predicate, order, asc, take, skip);
        }

        public async Task<List<T>?> GetPageOrderAsync<TKey, TProperty>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc, int take, int skip, params Expression<Func<T, TProperty>>[] includes)
        {
            return await _manager.GetPageOrderAsync(predicate, order, asc, take, skip, includes);
        }
    }
}
