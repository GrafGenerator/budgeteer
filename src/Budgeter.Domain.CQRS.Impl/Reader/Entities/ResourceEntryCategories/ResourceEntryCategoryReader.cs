using System.Linq;
using Budgeter.DAL.CQRS.Reader;

namespace Budgeter.Domain.CQRS.Impl.Reader.Entities.ResourceEntryCategories
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class ResourceEntryCategoryReader : IResourceEntryCategoryReader
    {
        private readonly IEntityReader<ResourceEntryCategory> _categoryReader;

        public ResourceEntryCategoryReader(IEntityReader<ResourceEntryCategory> categoryReader)
        {
            _categoryReader = categoryReader;
        }

        public ResourceEntryCategory FindByNameAndParent(string name, long? parentId)
        {
            var result =
                from category in _categoryReader
                where
                    name.Equals(category.Name) &&
                    parentId == category.ParentCategoryId

                select category;

            return result.FirstOrDefault();
        }
    }
}