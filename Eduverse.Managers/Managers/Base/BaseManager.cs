using Eduverse.DAL;
using Eduverse.DAL.Repositories.Implement.Bases;
using Eduverse.Managers.Managers.Contracts;
using Eduverse.Model.Entities.Bases;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Transactions;

namespace Eduverse.Managers.Managers.Base
{
    public class BaseManager<T> : IBaseManager<T>
        where T : BaseEntity
    {
        private readonly UnitOfWork<T> _uof;

        public BaseManager(UnitOfWork<T> uof) 
        {
            _uof = uof;
        }
        public async Task CreateAsync(T item)
        {
            try
            {
                await _uof.GetRepository(c => new BaseRepository<T>(c)).CreateAsync(item);
                _uof.Commit();
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
        }
        public async Task DeleteAsync(Guid uid)
        {
            try
            {
                await _uof.GetRepository(c => new BaseRepository<T>(c)).DeleteAsync(uid);
                _uof.Commit();
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
        }
        public async Task DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            try
            {
                await _uof.GetRepository(c => new BaseRepository<T>(c)).DeleteAsync(predicate);
                _uof.Commit();
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
        }
        public async Task<List<T>?> GetAllAsync()
        {
            try
            {
                return await _uof.GetRepository(c => new BaseRepository<T>(c)).GetAllAsync();
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
            return null;
        }
        public async Task<List<T>?> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            try
            {
                await _uof.GetRepository(c => new BaseRepository<T>(c)).GetAllAsync(predicate);
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
            return null;
        }
        public async Task<List<T>?> GetAllAsync<TProperty>(Expression<Func<T, bool>> predicate, params Expression<Func<T, TProperty>>[] includes)
        {
            try
            {
                await _uof.GetRepository(c => new BaseRepository<T>(c)).GetAllAsync(predicate, includes);
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
            return null;
        }
        public async Task<List<T>?> GetAllOrderAsync<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc)
        {
            try
            {
                await _uof.GetRepository(c => new BaseRepository<T>(c)).GetAllOrderAsync(predicate, order, asc);
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
            return null;
        }
        public async Task<List<T>?> GetAllOrderAsync<TKey, TProperty>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc, params Expression<Func<T, TProperty>>[] includes)
        {
            try
            {
                await _uof.GetRepository(c => new BaseRepository<T>(c)).GetAllOrderAsync(predicate, order, asc, includes);
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
            return null;
        }
        public async Task<T?> GetAsync(Guid uid)
        {
            try
            {
                await _uof.GetRepository(c => new BaseRepository<T>(c)).GetAsync(uid);
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
            return null;
        }
        public async Task<T?> GetAsync(Expression<Func<T, bool>> predicate)
        {
            try
            {
                await _uof.GetRepository(c => new BaseRepository<T>(c)).GetAsync(predicate);
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
            return null;
        }
        public async Task<T?> GetFirstAsync<TKey>(Expression<Func<T, TKey>> order)
        {
            try
            {
                await _uof.GetRepository(c => new BaseRepository<T>(c)).GetFirstAsync(order);
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
            return null;
        }
        public async Task<T?> GetLastAsync<TKey>(Expression<Func<T, TKey>> order)
        {
            try
            {
                await _uof.GetRepository(c => new BaseRepository<T>(c)).GetLastAsync(order);
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
            return null;
        }
        public async Task<List<T>?> GetPageAsync(int take, int skip)
        {
            try
            {
                await _uof.GetRepository(c => new BaseRepository<T>(c)).GetPageAsync(take, skip);
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
            return null;
        }
        public async Task<List<T>?> GetPageAsync(Expression<Func<T, bool>> predicate, int take, int skip)
        {
            try
            {
                await _uof.GetRepository(c => new BaseRepository<T>(c)).GetPageAsync(predicate, take, skip);
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
            return null;
        }
        public async Task<List<T>?> GetPageAsync<TProperty>(Expression<Func<T, bool>> predicate, int take, int skip, params Expression<Func<T, TProperty>>[] includes)
        {
            try
            {
                await _uof.GetRepository(c => new BaseRepository<T>(c)).GetPageAsync(predicate, take, skip, includes);
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
            return null;
        }
        public async Task<List<T>?> GetPageOrderAsync<TKey>(Expression<Func<T, TKey>> order, bool asc, int take, int skip)
        {
            try
            {
                await _uof.GetRepository(c => new BaseRepository<T>(c)).GetPageOrderAsync(order, asc, take, skip);
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
            return null;
        }
        public async Task<List<T>?> GetPageOrderAsync<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc, int take, int skip)
        {
            try
            {
                return await _uof.GetRepository(c => new BaseRepository<T>(c)).GetPageOrderAsync(predicate, order, asc, take, skip);
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
            return null;
        }
        public async Task<List<T>?> GetPageOrderAsync<TKey, TProperty>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc, int take, int skip, params Expression<Func<T, TProperty>>[] includes)
        {
            try
            {
                return await _uof.GetRepository(c => new BaseRepository<T>(c)).GetPageOrderAsync(predicate, order, asc, take, skip, includes);
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
            return null;
        }
        public async Task UpdateAsync(T item)
        {
            try
            {
                await _uof.GetRepository(c => new BaseRepository<T>(c)).UpdateAsync(item);
                _uof.Commit();
            }
            catch (TransactionException ex)
            {
                /// Полная пизда, надо логировать как критикал ошибку
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                _uof.Rollback();
            }
            finally
            {
                _uof.Dispose();
            }
        }
    }
}
