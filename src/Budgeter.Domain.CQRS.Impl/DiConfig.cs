using Budgeter.Domain.CQRS.Impl.Reader.Entities.ResourceEntryCategories;
using SimpleInjector;

namespace Budgeter.Domain.CQRS.Impl
{
    public static class DiConfig
    {
        public static Container UseReaders(this Container container)
        {
            container.Register<IResourceEntryCategoryReader, ResourceEntryCategoryReader>(Lifestyle.Scoped);
            return container;
        }
    }
}