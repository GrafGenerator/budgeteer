using System;
using Budgeter.BL.Core.Handlers;
using Budgeter.BL.Core.Handlers.GenericResults;
using Budgeter.BL.Core.HandlingScope;
using Budgeter.BL.Impl.IdentityRegistry;
using Budgeter.Domain;

namespace Budgeter.BL.Impl.Handlers.ResourceDeltaCategory.AddResourceDeltaCategory
{
    public class AddResourceEntryCategoryHandler : OperationHandler<AddResourceEntryCategoryCommand,
        AddEntityResult<ResourceEntryCategory>>
    {
        private readonly IHandlingScopeFactory _scopeFactory;

        public AddResourceEntryCategoryHandler(IHandlingScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        protected override OperationResult<AddEntityResult<ResourceEntryCategory>> HandleInternal(
            AddResourceEntryCategoryCommand command)
        {
            using (var scope = _scopeFactory.Enter(HandlerIdentities.AddResourceEntryCategory))
            {
                var category = new ResourceEntryCategory
                {
                    Id = DateTime.Now.Ticks, // TODO: FIX THIS !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    Name = command.Name
                };

                scope.Repo<ResourceEntryCategory>()
                    .Add(category);

                scope.Commit();
            }

            return null;
        }
    }
}