using Eduverse.Model.Entities.Bases;
using System.Linq.Expressions;

namespace Eduverse.Managers.Managers.Contracts
{
    public interface IBaseManager<T>
        where T : BaseEntity
    {
        /// <summary>
        /// Получение сущности по уникальному идентификатору
        /// </summary>
        /// <param name="uid">Уникальный идентификатор</param>
        /// <returns>Сущность</returns>
        public Task<T?> GetAsync(Guid uid);

        /// <summary>
        /// Получение сущности по уникальному идентификатору
        /// </summary>
        /// <param name="predicate">Лямбда функция</param>
        /// <returns>Сущность</returns>
        public Task<T?> GetAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Взять первый по сортировке
        /// </summary>
        /// <param name="order">Лямбда функция</param>
        /// <returns></returns>
        public Task<T?> GetFirstAsync<TKey>(Expression<Func<T, TKey>> order);

        /// <summary>
        /// Взять последний по сортировке
        /// </summary>
        /// <param name="order">Лямбда функция</param>
        /// <returns></returns>
        public Task<T?> GetLastAsync<TKey>(Expression<Func<T, TKey>> order);

        /// <summary>
        /// Получение всех сущностей
        /// </summary>
        /// <returns>Список сущностей</returns>
        public Task<List<T>?> GetAllAsync();

        /// <summary>
        /// Получение списка сущностей
        /// </summary>
        /// <param name="predicate">Лямда функция</param>
        /// <returns>Список сущностей</returns>
        public Task<List<T>?> GetAllAsync(Expression<Func<T, bool>> predicate);
        public Task<List<T>?> GetAllAsync<TProperty>(Expression<Func<T, bool>> predicate, params Expression<Func<T, TProperty>>[] includes);

        /// <summary>
        /// Получение отсортированного списка сущностей
        /// </summary>
        /// <param name="predicate">Лямда функция</param>
        /// <param name="order"></param>
        /// <returns>Список сущностей</returns>
        public Task<List<T>?> GetAllOrderAsync<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc);
        public Task<List<T>> GetAllOrderAsync<TKey, TProperty>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc, params Expression<Func<T, TProperty>>[] includes);

        /// <summary>
        /// Получение страницы
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        public Task<List<T>?> GetPageAsync(int take, int skip);

        /// <summary>
        /// Получение страницы с фильтрацией
        /// </summary>
        /// <param name="predicate">Лямбда функция</param>
        /// <param name="take">Сколько взять</param>
        /// <param name="skip">Сколько пропустить</param>
        /// <returns></returns>
        public Task<List<T>?> GetPageAsync(Expression<Func<T, bool>> predicate, int take, int skip);
        public Task<List<T>> GetPageAsync<TProperty>(Expression<Func<T, bool>> predicate, int take, int skip, params Expression<Func<T, TProperty>>[] includes);

        /// <summary>
        /// Получение отсортированной страницы
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="order"></param>
        /// <param name="asc"></param>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        public Task<List<T>?> GetPageOrderAsync<TKey>(Expression<Func<T, TKey>> order, bool asc, int take, int skip);

        /// <summary>
        /// Получение отсортированной страницы с фильтрацией
        /// </summary>
        /// <param name="predicate">Лямбда функция</param>
        /// <param name="take">Сколько взять</param>
        /// <param name="skip">Сколько пропустить</param>
        /// <param name="order"></param>
        /// <returns></returns>
        public Task<List<T>?> GetPageOrderAsync<TKey>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc, int take, int skip);
        public Task<List<T>> GetPageOrderAsync<TKey, TProperty>(Expression<Func<T, bool>> predicate, Expression<Func<T, TKey>> order, bool asc, int take, int skip, params Expression<Func<T, TProperty>>[] includes);

        /// <summary>
        /// Создание сущности
        /// </summary>
        /// <param name="item">Сущность</param>
        /// <returns></returns>
        public Task CreateAsync(T item);

        /// <summary>
        /// Редактирование сущности
        /// </summary>
        /// <param name="item">Сущность</param>
        /// <returns></returns>
        public Task UpdateAsync(T item);

        /// <summary>
        /// Удаление сущности по уникальному идентификатору
        /// </summary>
        /// <param name="uid">Уникальный идентификатор</param>
        /// <returns></returns>
        public Task DeleteAsync(Guid uid);

        /// <summary>
        /// Удаление сущностей по условию(использовать с осторожностью!)
        /// </summary>
        /// <param name="predicate">Лямда выражение</param>
        /// <returns></returns>
        public Task DeleteAsync(Expression<Func<T, bool>> predicate);
    }
}
