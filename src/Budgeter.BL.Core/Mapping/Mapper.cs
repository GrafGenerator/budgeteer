using AutoMapper;

namespace Budgeter.BL.Core.Mapping
{
    internal class ContextualMapper<TContext> : IContextualMapper<TContext>
        where TContext : class, IMappingContext
    {
        private readonly MapperConfiguration _config;

        public ContextualMapper(IMappingContextConfig<TContext> context)
        {
            _config = context.GetConfiguration();
        }

        public IMapper Spawn()
        {
            return _config.CreateMapper();
        }
    }
}