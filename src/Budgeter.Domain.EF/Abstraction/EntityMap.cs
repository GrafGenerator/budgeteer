using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Budgeter.Domain.EF.Abstraction
{
    public class EntityMap: ModelBuilder
    {
        public EntityMap(ConventionSet conventions) : base(conventions)
        {
        }
    }
}