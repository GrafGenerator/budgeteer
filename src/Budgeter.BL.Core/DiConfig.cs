using Budgeter.BL.Core.Handlers;
using Budgeter.BL.Core.HandlingScope;
using Budgeter.BL.Core.Mapping;
using SimpleInjector;

namespace Budgeter.BL.Core
{
    public static class DiConfig
    {
        public static Container UseBlHandlingCore(this Container container)
        {
            container.Register<IOperationHandlersFactory, OperationHandlersFactory>(Lifestyle.Scoped);
            container.Register<IHandlingScopeFactory, HandlingScopeFactory>(Lifestyle.Scoped);
            container
                .Register<IHandlingScopesStack<HandlingScope.HandlingScope>, HandlingScopesStack>(Lifestyle.Scoped);

            container.Register(typeof(IContextualMapper<>), typeof(ContextualMapper<>), Lifestyle.Scoped);

            return container;
        }
    }
}