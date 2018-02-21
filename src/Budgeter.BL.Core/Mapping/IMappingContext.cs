using AutoMapper;

namespace Budgeter.BL.Core.Mapping
{
    public interface IMappingContext
    {
    }

    public interface IMappingContextConfig<TContext>
        where TContext : class, IMappingContext
    {
        MapperConfiguration GetConfiguration();
    }
}