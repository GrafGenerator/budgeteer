using System.Collections.Generic;

namespace Budgeter.BL.Core.HandlingScope
{
    internal class HandlingScopesStack : IHandlingScopesStack<HandlingScope>
    {
        private readonly Stack<HandlingScope> _scopes = new Stack<HandlingScope>();

        public void EnterScope(HandlingScope scope)
        {
            _scopes.Push(scope);
        }

        public HandlingScope LeaveLastScope()
        {
            _scopes.TryPop(out var lastScope);
            return lastScope;
        }

        public HandlingScope GetCurrentScope()
        {
            _scopes.TryPeek(out var currentScope);
            return currentScope;
        }
    }

    internal interface IHandlingScopesStack<T>
        where T : HandlingScope
    {
        void EnterScope(T scope);
        T LeaveLastScope();
        T GetCurrentScope();
    }
}