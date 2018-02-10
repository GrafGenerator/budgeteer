using Budgeter.Domain.EF.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Budgeter.Domain.EF.Configuration
{
    public class ResourceDeltaCategoryMap: IEntityMap<ResourceDeltaCategory>
    {
        public void BuildModel(EntityTypeBuilder<ResourceDeltaCategory> builder)
        {
            builder.ToTable("ResourceDeltaCategory");

            builder.Property(t => t.Id).ValueGeneratedNever();
            
            builder.HasOne(t => t.ParentCategory)
            builder.Property(t => t.ParentCategoryId)
        }
    }
}