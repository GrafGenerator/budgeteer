using Budgeter.BL.Core.Results;
using Budgeter.Domain;

namespace Budgeter.BL.Core.Impl
{
    public class AddResourceDeltaCategoryHandler : OperationHandler<AddResourceDeltaCategoryCommand, AddEntityResult<ResourceDeltaCategory>>
    {
        protected override OperationResult<AddEntityResult<ResourceDeltaCategory>> HandleInternal(AddResourceDeltaCategoryCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}