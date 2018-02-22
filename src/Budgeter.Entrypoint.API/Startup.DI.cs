using Budgeter.BL.Core;
using Budgeter.BL.Impl;
using Budgeter.DAL.CQRS;
using Budgeter.Domain.CQRS.Impl;
using Budgeter.Domain.EF;
using Microsoft.AspNetCore.Builder;
using SimpleInjector;

namespace Budgeter.Entrypoint.API
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public static class StartupDiExtensions
    {
        public static void ConfigureAppRegistrations(this Container container, IApplicationBuilder app)
        {
            container.RegisterMvcControllers(app);
            container.RegisterMvcViewComponents(app);

            container
                .UseEfAbstractions()
                .UseDalAbstractions()
                .UseBlHandlingCore()
                .UseBlHandlingImplementations()
                .UseMappings()
                .UseReaders();
        }
    }
}