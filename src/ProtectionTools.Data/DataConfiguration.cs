namespace ProtectionTools.Data {
    using Microsoft.Data.Entity;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.PlatformAbstractions;
    using Repository.EF;

    public class DataConfiguration {
        private readonly IConfigurationRoot _configuration;

        public DataConfiguration(IApplicationEnvironment appEnv) {
            var confBuilder = new ConfigurationBuilder()
                .SetBasePath(appEnv.ApplicationBasePath)
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();
            _configuration = confBuilder.Build();
        }

        public void Configure(IServiceCollection services) {
            services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<DataContext>(options =>
                    options.UseSqlServer(_configuration["Data:DefaultConnection:ConnectionString"]));
        }
    }
}