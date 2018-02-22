using System;
using Budgeter.BL.Core.Handlers;
using Budgeter.BL.Core.Handlers.GenericResults;
using Budgeter.BL.Core.HandlingScope;
using Budgeter.BL.Impl.IdentityRegistry;
using Budgeter.DAL.CQRS.Reader;
using Budgeter.Domain;
using Budgeter.Domain.CQRS.Impl.Reader.Entities.ResourceEntryCategories;

namespace Budgeter.BL.Impl.Handlers.ResourceDeltaCategory.AddResourceDeltaCategory
{
    public class AddResourceEntryCategoryHandler : OperationHandler<AddResourceEntryCategoryCommand,
        AddEntityResult<ResourceEntryCategory>>
    {
        private readonly IHandlingScopeFactory _scopeFactory;
        private readonly IResourceEntryCategoryReader _resourceEntryCategoryReader;

        public AddResourceEntryCategoryHandler(IHandlingScopeFactory scopeFactory,
            IResourceEntryCategoryReader resourceEntryCategoryReader)
        {
            _scopeFactory = scopeFactory;
            _resourceEntryCategoryReader = resourceEntryCategoryReader;
        }

        protected override OperationResult<AddEntityResult<ResourceEntryCategory>> HandleInternal(
            AddResourceEntryCategoryCommand command)
        {
            using (var scope = _scopeFactory.Enter(HandlerIdentities.AddResourceEntryCategory))
            {
                var existingCategory = _resourceEntryCategoryReader.FindByNameAndParent(command.Name, command.ParentId);

                if (existingCategory != null)
                {
                    throw new InvalidOperationException($"Category with name {command.Name} and parent {command.ParentId} already exists.");
                }

                var category = new ResourceEntryCategory
                {
                    Id = DateTime.Now.Ticks, // TODO: FIX THIS !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    Name = command.Name,
                    ParentCategoryId = command.ParentId
                };

                scope.Repo<ResourceEntryCategory>()
                    .Add(category);

                scope.Commit();
            }

            return null;
        }
    }
}