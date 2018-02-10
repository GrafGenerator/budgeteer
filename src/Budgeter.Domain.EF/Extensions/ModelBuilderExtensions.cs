using Budgeter.Domain.EF.Abstraction;
using Budgeter.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Budgeter.Domain.EF.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder UseMap<TEntity, TEntityMap>(this ModelBuilder builder)
            where TEntityMap : class, IEntityMap<TEntity>, new()
            where TEntity : class, IEntity
        {
            return UseMap(builder, new TEntityMap());
        }
        
        public static ModelBuilder UseMap<TEntity>(this ModelBuilder builder, IEntityMap<TEntity> map)
            where TEntity : class, IEntity
        {
            map.BuildModel(builder.Entity<TEntity>());
            return builder;
        }
    }
}