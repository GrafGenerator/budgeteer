using System;
using Budgeter.BL.Core;
using Budgeter.BL.Core.GenericResults;

namespace Budgeter.BL.Impl.Handlers.ResourceDeltaCategory.AddResourceDeltaCategory
{
    public class AddResourceDeltaCategoryHandler : OperationHandler<AddResourceDeltaCategoryCommand,
        AddEntityResult<Domain.ResourceDeltaCategory>>
    {
        protected override OperationResult<AddEntityResult<Domain.ResourceDeltaCategory>> HandleInternal(
            AddResourceDeltaCategoryCommand command)
        {
            throw new NotImplementedException();
        }
    }
}