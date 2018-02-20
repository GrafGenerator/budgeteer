using Budgeter.Domain.Model;

namespace Budgeter.Domain
{
    public class ResourceEntryCategory : IEntity
    {
        public long? ParentCategoryId { get; set; }

        public string Name { get; set; }

        public virtual ResourceEntryCategory ParentCategory { get; set; }
        public long Id { get; set; }
    }
}