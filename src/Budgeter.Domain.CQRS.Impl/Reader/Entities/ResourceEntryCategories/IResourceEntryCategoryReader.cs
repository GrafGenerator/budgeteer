namespace Budgeter.Domain.CQRS.Impl.Reader.Entities.ResourceEntryCategories
{
    public interface IResourceEntryCategoryReader
    {
        ResourceEntryCategory FindByNameAndParent(string name, long? parentId);
    }
}