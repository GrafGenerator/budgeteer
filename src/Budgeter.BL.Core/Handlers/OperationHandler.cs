namespace Budgeter.BL.Core.Handlers
{
    public abstract class OperationHandler<TCommand, TResult> : IOperationHandler<TCommand, TResult>
        where TCommand : class, IOperationCommand
        where TResult : class
    {
        public virtual string Description { get; } = "{ handler description not provided }";

        public OperationResult<TResult> Handle(TCommand command)
        {
            return HandleInternal(command);
        }

        protected abstract OperationResult<TResult> HandleInternal(TCommand command);
    }
}