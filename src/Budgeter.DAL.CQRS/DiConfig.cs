using Budgeter.DAL.CQRS.Reader;
using Budgeter.DAL.CQRS.Repository;
using SimpleInjector;

namespace Budgeter.DAL.CQRS
{
    public static class DiConfig
    {
        public static Container UseDalAbstractions(this Container container)
        {
            container.Register(typeof(IRepository<>), typeof(GenericEntityRepository<>), Lifestyle.Scoped);
            container.Register(typeof(IEntityReader<>), typeof(EntityReader<>), Lifestyle.Scoped);

            return container;
        }
    }
}