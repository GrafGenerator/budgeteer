using Budgeter.Domain.Model;

namespace Budgeter.Domain
{
    public class ResourceDeltaCategory: IEntity
    {
        public int Id { get; set; }
        
        public int? ParentCategoryId { get; set; }
            
        public virtual ResourceDeltaCategory ParentCategory { get; set; }
    }
}