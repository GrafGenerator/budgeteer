using System.ComponentModel.DataAnnotations.Schema;

namespace Budgeter.Domain.EF.Configuration
{
    public class ResourceDeltaMap
    {
        public ResourceDeltaMap()
        {
            //ToTable("ResourceDelta");

            //Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}