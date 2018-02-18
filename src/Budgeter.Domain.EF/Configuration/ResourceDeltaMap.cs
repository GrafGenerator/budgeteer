using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Budgeter.Domain.EF.Configuration
{
    public class ResourceDeltaMap : IEntityTypeConfiguration<ResourceDelta>
    {
        public void Configure(EntityTypeBuilder<ResourceDelta> builder)
        {
            builder.ToTable("ResourceDelta");

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