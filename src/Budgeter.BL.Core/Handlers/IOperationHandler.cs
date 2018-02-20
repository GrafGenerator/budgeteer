namespace Budgeter.BL.Core.Handlers
{
    // ReSharper disable once TypeParameterCanBeVariant
    public interface IOperationHandler<TCommand, TResult>
        where TCommand : class, IOperationCommand
        where TResult : class
    {
        string Description { get; }
        OperationResult<TResult> Handle(TCommand command);
    }
}