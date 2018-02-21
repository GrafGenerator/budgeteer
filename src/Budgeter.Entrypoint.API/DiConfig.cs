using Budgeter.BL.Core.Mapping;
using Budgeter.Entrypoint.API.Mapping.ApiToBL;
using SimpleInjector;

namespace Budgeter.Entrypoint.API
{
    public static class DiConfig
    {
        public static Container UseMappings(this Container container)
        {
            container.RegisterCollection(typeof(IMappingContext), typeof(ApiToBlContext).Assembly);
            container.Register(typeof(IMappingContextConfig<>), new[] {typeof(ApiToBlContext).Assembly},
                Lifestyle.Singleton);
            return container;
        }
    }
}