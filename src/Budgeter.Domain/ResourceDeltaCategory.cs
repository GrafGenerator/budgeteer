using Budgeter.Domain.Model;

namespace Budgeter.Domain
{
    public class ResourceDeltaCategory: IEntity
    {
        public long Id { get; set; }
        public long? ParentCategoryId { get; set; }

        public string Name { get; set; }

        public virtual ResourceDeltaCategory ParentCategory { get; set; }
    }
}