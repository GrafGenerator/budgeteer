using System;
using Budgeter.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Budgeter.DAL.CQRS.Repository
{
    public class GenericEntityRepository<T> : IRepository<T>
        where T : class, IEntity

    {
        private readonly DbContext _context;
        private readonly DbSet<T> _set;

        public GenericEntityRepository(DbContext context)
        {
            _context = context;
            _set = context.Set<T>();
        }

        public void Add(T entity)
        {
            _set.Add(entity);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}