using Budgeter.BL.Core.Handlers;
using Budgeter.BL.Core.HandlingScope;
using SimpleInjector;

namespace Budgeter.BL.Core
{
    public static class DiConfig
    {
        public static Container UseBlHandlingCore(this Container container)
        {
            container.Register<IOperationHandlersFactory, OperationHandlersFactory>(Lifestyle.Scoped);
            container.Register<IHandlingScopeFactory, HandlingScopeFactory>(Lifestyle.Scoped);
            return container;
        }
    }
}