using Budgeter.BL.Core.HandlingIdentities;
using SimpleInjector;

namespace Budgeter.BL.Core.HandlingScope
{
    internal class HandlingScopeFactory : IHandlingScopeFactory
    {
        private readonly Container _container;

        public HandlingScopeFactory(Container container)
        {
            _container = container;
        }

        public IHandlingScope Enter(HandlerIdentity identity)
        {
            return new HandlingScope(_container, identity);
        }
    }
}