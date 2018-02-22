using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Budgeter.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Budgeter.DAL.CQRS.Reader
{
    // ReSharper disable once TypeParameterCanBeVariant
    public interface IEntityReader<TEntity> : IQueryable<TEntity>
        where TEntity : class, IEntity
    {
        IQueryable<TEntity> WithTracking();
    }

    internal class EntityReader<TEntity> : IEntityReader<TEntity> where TEntity : class, IEntity
    {
        private readonly IQueryable<TEntity> _queryable;
        private readonly DbSet<TEntity> _set;

        public EntityReader(DbContext context)
        {
            _set = context.Set<TEntity>();
            _queryable = _set.AsNoTracking();
        }

        public IQueryable<TEntity> WithTracking() => _set;

        public IEnumerator<TEntity> GetEnumerator() => _queryable.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public Type ElementType => _queryable.ElementType;
        public Expression Expression => _queryable.Expression;
        public IQueryProvider Provider => _queryable.Provider;
    }
}