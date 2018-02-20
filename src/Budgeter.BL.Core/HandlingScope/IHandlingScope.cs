using System;
using Budgeter.BL.Core.HandlingIdentities;
using Budgeter.DAL.CQRS.Repository;
using Budgeter.Domain.Model;

namespace Budgeter.BL.Core.HandlingScope
{
    public interface IHandlingScope: IDisposable
    {
        IRepository<T> Repo<T>() 
            where T : class, IEntity;

        HandlerIdentity Identity { get; }
        void Commit();
    }
}