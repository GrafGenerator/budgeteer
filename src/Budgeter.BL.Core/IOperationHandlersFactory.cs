namespace Budgeter.BL.Core
{
    public interface IOperationHandlersFactory
    {
        IOperationHandler<TCommand, TResult> Get<TCommand, TResult>()
            where TCommand : class, IOperationCommand
            where TResult : class;
    }
}