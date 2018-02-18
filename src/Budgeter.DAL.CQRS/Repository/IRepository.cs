using Budgeter.Domain.Model;

namespace Budgeter.DAL.CQRS.Repository
{
    // ReSharper disable once TypeParameterCanBeVariant
    public interface IRepository<T>
        where T : class, IEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}