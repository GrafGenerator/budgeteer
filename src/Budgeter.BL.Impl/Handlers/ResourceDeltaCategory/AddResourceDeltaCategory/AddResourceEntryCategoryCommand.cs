using Budgeter.BL.Core.Handlers;

namespace Budgeter.BL.Impl.Handlers.ResourceDeltaCategory.AddResourceDeltaCategory
{
    public class AddResourceEntryCategoryCommand : IOperationCommand
    {
        public string Name { get; set; }
    }
}