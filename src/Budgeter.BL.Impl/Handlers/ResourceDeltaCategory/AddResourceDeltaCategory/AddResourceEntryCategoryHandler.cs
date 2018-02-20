using System;
using Budgeter.BL.Core.Handlers;
using Budgeter.BL.Core.Handlers.GenericResults;
using Budgeter.Domain;

namespace Budgeter.BL.Impl.Handlers.ResourceDeltaCategory.AddResourceDeltaCategory
{
    public class AddResourceEntryCategoryHandler : OperationHandler<AddResourceEntryCategoryCommand,
        AddEntityResult<ResourceEntryCategory>>
    {
        protected override OperationResult<AddEntityResult<ResourceEntryCategory>> HandleInternal(
            AddResourceEntryCategoryCommand command)
        {
            throw new NotImplementedException();
        }
    }
}