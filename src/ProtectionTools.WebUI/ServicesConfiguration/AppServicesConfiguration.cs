namespace ProtectionTools.WebAPI.ServicesConfiguration {
    using Core.Buses;
    using Data.Repository;
    using Data.Repository.EF.Impl;
    using Microsoft.Extensions.DependencyInjection;
    using Models.Engines;
    using Models.FusingTools.Switchers;
    using Services.Buses;
    using Services.Engines;

    public static class AppServicesConfiguration {
        public static void Configure(IServiceCollection services) {
            services.AddScoped<IBusService, BusService>();
            services.AddScoped<IEngineService, EngineService>();

            services.AddScoped<IBusCalc, BusCalc>();

            services.AddScoped<IRepository<Engine>, EnginesRepository>();
            services.AddScoped<IRepository<AutomaticSwitcher>, SwitchersRepository>();
        }
    }
}