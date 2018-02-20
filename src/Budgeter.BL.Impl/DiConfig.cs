using Budgeter.BL.Core.Handlers;
using Budgeter.BL.Impl.Handlers.ResourceDeltaCategory.AddResourceDeltaCategory;
using SimpleInjector;

namespace Budgeter.BL.Impl
{
    public static class DiConfig
    {
        public static Container UseBlHandlingImplementations(this Container container)
        {
            var handlersAssemblies = new[] {typeof(AddResourceEntryCategoryHandler).Assembly};

            container.Register(typeof(IOperationHandler<,>), handlersAssemblies, Lifestyle.Scoped);

            return container;
        }
    }
}