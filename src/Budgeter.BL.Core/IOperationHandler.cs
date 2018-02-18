namespace Budgeter.BL.Core
{
    // ReSharper disable once TypeParameterCanBeVariant
    public interface IOperationHandler<TCommand, TResult>
        where TCommand : class, IOperationCommand
        where TResult : class
    {
        OperationResult<TResult> Handle(TCommand command);
    }
}