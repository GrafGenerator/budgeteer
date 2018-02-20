namespace Budgeter.BL.Core.Handlers
{
    public class OperationResult<TResult>
        where TResult : class
    {
        private OperationResult(bool globalStatus, TResult result)
        {
            GlobalStatus = globalStatus;
            Result = result;
        }

        public bool GlobalStatus { get; }

        public TResult Result { get; }

        public static OperationResult<TR> Ok<TR>(TR result) where TR : class
        {
            return new OperationResult<TR>(true, result);
        }

        public static OperationResult<TResult> Fail()
        {
            return new OperationResult<TResult>(true, null);
        }
    }
}