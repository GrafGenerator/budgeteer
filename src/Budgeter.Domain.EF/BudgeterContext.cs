using Budgeter.Domain.EF.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Budgeter.Domain.EF
{
    public class BudgeterContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(
                    @"Data Source=ROCKET;Initial Catalog=BudgeterCore;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ResourceEntryMap());
            modelBuilder.ApplyConfiguration(new ResourceEntryCategoryMap());
        }
    }
}