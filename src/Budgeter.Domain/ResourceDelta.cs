using Budgeter.Domain.Model;

namespace Budgeter.Domain
{
    public class ResourceDelta: IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        
        public decimal Amount { get; set; }
        
        public virtual ResourceDeltaCategory  Category { get; set; }
    }
}