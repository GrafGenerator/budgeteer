using SimpleInjector;

namespace Budgeter.BL.Core
{
    public class OperationHandlersFactory : IOperationHandlersFactory
    {
        private readonly Container _container;

        public OperationHandlersFactory(Container container)
        {
            _container = container;
        }

        public IOperationHandler<TCommand, TResult> Get<TCommand, TResult>()
            where TCommand : class, IOperationCommand
            where TResult : class
        {
            var operationHandler = _container.GetInstance<IOperationHandler<TCommand, TResult>>();
            return operationHandler;
        }
    }
}