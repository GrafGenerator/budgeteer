using Microsoft.EntityFrameworkCore;
using SimpleInjector;

namespace Budgeter.Domain.EF
{
    public static class DiConfig
    {
        public static Container UseEfAbstractions(this Container container)
        {
            container.Register<DbContext, BudgeterContext>(Lifestyle.Scoped);

            return container;
        }
    }
}