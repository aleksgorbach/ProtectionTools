namespace ProtectionTools.WebAPI.ServicesConfiguration {
    using Data.Repository;
    using Data.Repository.EF;
    using Microsoft.Extensions.DependencyInjection;
    using Models.Engines;
    using Services.Buses;
    using Services.Engines;

    public static class AppServicesConfiguration {
        public static void Configure(IServiceCollection services) {
            services.AddScoped<IBusService, BusService>();
            services.AddScoped<IEngineService, EngineService>();

            services.AddScoped<IRepository<Engine>, EnginesRepository>();
        }
    }
}