namespace ProtectionTools.WebUI.ServicesConfiguration {
    using AutoMapper;
    using Core.Elements.Connections.Factory;
    using Core.Elements.ElectroReceivers;
    using Core.Lines.Factories;
    using Microsoft.Extensions.DependencyInjection;
    using Services;
    using ViewModels;

    public static class AppServicesConfiguration {
        public static void Configure(IServiceCollection services) {
            services.AddScoped<IBusService, BusService>();
            services.AddScoped<IConnectionFactory, ConnectionFactory>();
            services.AddScoped<ILineFactory, LineFactory>();

            var mappingConfig = new MapperConfiguration(CreateMappings);
            services.AddInstance(mappingConfig.CreateMapper());
        }

        private static void CreateMappings(IMapperConfiguration config) {
            config.CreateMap<ElementViewModel, ElectroReceiver>();
        }
    }
}