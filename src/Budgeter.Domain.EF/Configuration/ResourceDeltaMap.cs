using Budgeter.Domain.EF.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Budgeter.Domain.EF.Configuration
{
    public class ResourceDeltaMap: IEntityMap<ResourceDelta>
    {
        public void BuildModel(EntityTypeBuilder<ResourceDelta> builder)
        {
            builder.ToTable("ResourceDelta");

            builder.Property(t => t.Id).ValueGeneratedNever();
        }
    }
}