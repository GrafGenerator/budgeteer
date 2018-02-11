using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Budgeter.Domain.EF.Configuration
{
    public class ResourceDeltaCategoryMap: IEntityTypeConfiguration<ResourceDeltaCategory>
    {
        public void Configure(EntityTypeBuilder<ResourceDeltaCategory> builder)
        {
            builder.ToTable("ResourceDeltaCategory");

            builder.Property(t => t.Id).ValueGeneratedNever();
            builder.Property(t => t.Name).IsRequired().HasMaxLength(256);

            builder
                .HasOne(t => t.ParentCategory)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}