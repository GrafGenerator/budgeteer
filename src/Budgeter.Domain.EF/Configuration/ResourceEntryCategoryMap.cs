using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Budgeter.Domain.EF.Configuration
{
    public class ResourceEntryCategoryMap : IEntityTypeConfiguration<ResourceEntryCategory>
    {
        public void Configure(EntityTypeBuilder<ResourceEntryCategory> builder)
        {
            builder.ToTable("ResourceEntryCategory");

            builder.Property(t => t.Id).ValueGeneratedNever();
            builder.Property(t => t.Name).IsRequired().HasMaxLength(256);

            builder
                .HasOne(t => t.ParentCategory)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}