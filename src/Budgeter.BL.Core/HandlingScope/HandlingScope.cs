using Budgeter.BL.Core.HandlingIdentities;
using Budgeter.DAL.CQRS.Repository;
using Budgeter.Domain.Model;
using Microsoft.EntityFrameworkCore;
using SimpleInjector;

namespace Budgeter.BL.Core.HandlingScope
{
    internal class HandlingScope : IHandlingScope
    {
        private readonly Container _container;
        private readonly DbContext _context;
        private readonly IHandlingScopesStack<HandlingScope> _handlingScopesStack;
        private readonly HandlingScope _parentScope;
        private bool _isCommitted;

        public HandlingScope(Container container, HandlerIdentity identity)
        {
            Identity = identity;
            _container = container;
            _context = _container.GetInstance<DbContext>();
            _handlingScopesStack = _container.GetInstance<IHandlingScopesStack<HandlingScope>>();

            _parentScope = _handlingScopesStack.GetCurrentScope();
            _handlingScopesStack.EnterScope(this);
        }

        public HandlerIdentity Identity { get; }

        public IRepository<T> Repo<T>()
            where T : class, IEntity
        {
            return _container.GetInstance<IRepository<T>>();
        }

        public void Commit()
        {
            EnsureCommitted();
        }

        public void Dispose()
        {
            EnsureCommitted();
        }

        private void EnsureCommitted()
        {
            if (_isCommitted) return;

            if (_parentScope == null) // root scope, do real changes commit
                _context.SaveChanges();

            _isCommitted = true;
            _handlingScopesStack.LeaveLastScope();
        }
    }
}