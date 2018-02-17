using Budgeter.Domain.Model;

namespace Budgeter.Domain
{
    public class ResourceDelta: IEntity
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }

        public decimal Amount { get; set; }
        public string Description { get; set; }

        public virtual ResourceDeltaCategory  Category { get; set; }
    }
}