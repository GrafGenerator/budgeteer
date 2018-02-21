using AutoMapper;
using Budgeter.BL.Core.Mapping;
using Budgeter.BL.Impl.Handlers.ResourceDeltaCategory.AddResourceDeltaCategory;
using Budgeter.Entrypoint.API.Controllers.ResourceEntryCategories.Models;

namespace Budgeter.Entrypoint.API.Mapping.ApiToBL
{
    public class ApiToBlContextConfig : IMappingContextConfig<ApiToBlContext>
    {
        private readonly MapperConfiguration _mapperConfiguration;

        public ApiToBlContextConfig()
        {
            _mapperConfiguration = CreateConfiguration();
        }

        public MapperConfiguration GetConfiguration()
        {
            return _mapperConfiguration;
        }

        private static MapperConfiguration CreateConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<CreateResourceEntryCategoryDto, AddResourceEntryCategoryCommand>();
                }
            );

            return config;
        }
    }
}