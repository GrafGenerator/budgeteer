using Budgeter.Domain.Model;

namespace Budgeter.Domain
{
    public class ResourceEntry : IEntity
    {
        public long CategoryId { get; set; }

        public decimal Amount { get; set; }
        public string Description { get; set; }

        public virtual ResourceEntryCategory Category { get; set; }
        public long Id { get; set; }
    }
}