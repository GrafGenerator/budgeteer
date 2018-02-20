using System;
using Budgeter.BL.Core;
using Budgeter.BL.Core.GenericResults;
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