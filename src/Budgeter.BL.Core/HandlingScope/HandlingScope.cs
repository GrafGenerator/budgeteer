using System;
using Budgeter.BL.Core.HandlingIdentities;
using Budgeter.DAL.CQRS.Repository;
using Budgeter.Domain.Model;
using Microsoft.EntityFrameworkCore;
using SimpleInjector;

namespace Budgeter.BL.Core.HandlingScope
{
    internal class HandlingScope : IHandlingScope
    {
        public HandlerIdentity Identity { get; }
        private readonly Container _container;
        private readonly DbContext _context;
        private bool _isSaved = true;
        
        public HandlingScope(Container container, HandlerIdentity identity)
        {
            Identity = identity;
            _container = container;
            _context = _container.GetInstance<DbContext>();
        }

        public IRepository<T> Repo<T>() 
            where T : class, IEntity
        {
            _isSaved = false;
            return _container.GetInstance<IRepository<T>>();
        }

        public void Commit()
        {
            if(!_isSaved)
            {
                _context.SaveChanges();
                _isSaved = true;
            }
        }
        public void Dispose()
        {
            if(!_isSaved)
            {
                _context.SaveChanges();
                _isSaved = true;
            }
            _container?.Dispose();
        }
    }
}