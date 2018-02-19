using SimpleInjector;

namespace Budgeter.BL.Core
{
    public static class DiConfig
    {
        public static Container UseBlHandlingCore(this Container container)
        {
            container.Register<IOperationHandlersFactory, OperationHandlersFactory>(Lifestyle.Scoped);
            return container;
        }
    }
}