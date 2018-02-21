using AutoMapper;

namespace Budgeter.BL.Core.Mapping
{
    public interface IContextualMapper<T>
        where T : class, IMappingContext
    {
        IMapper Spawn();
    }
}