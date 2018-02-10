using Budgeter.Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Budgeter.Domain.EF.Abstraction
{
    public interface IEntityMap<TEntity>
        where TEntity : class, IEntity
    {
        void BuildModel(EntityTypeBuilder<TEntity> builder);
    }
}