using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace Budgeter.Domain.EF.Configuration
{
    public class ResourceDeltaMap: EntityMappingConfiguration<ResourceDelta>
    {
        public ResourceDeltaMap()
        {
            ToTable("ResourceDelta");

            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}