using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Budgeter.Domain.EF.Configuration
{
    public class ResourceEntryMap : IEntityTypeConfiguration<ResourceEntry>
    {
        public void Configure(EntityTypeBuilder<ResourceEntry> builder)
        {
            builder.ToTable("ResourceEntry");

            builder.Property(t => t.Id).ValueGeneratedNever();
            builder.Property(t => t.Amount).IsRequired();
            builder.Property(t => t.Description).HasMaxLength(1000);

            builder
                .HasOne(t => t.Category)
                .WithMany()
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}