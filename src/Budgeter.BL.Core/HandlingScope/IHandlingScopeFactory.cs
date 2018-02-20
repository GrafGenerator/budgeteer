using Budgeter.BL.Core.HandlingIdentities;

namespace Budgeter.BL.Core.HandlingScope
{
    public interface IHandlingScopeFactory
    {
        IHandlingScope Enter(HandlerIdentity identity);
    }
}