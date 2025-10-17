using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RealEstateManagement.Services.Client;
using RealEstateManagement.Services.Owner;
using RealEstateManagement.Services.Properties;
using RealEstateManagement.Data.Repositories.Client;
using RealEstateManagement.Data.Repositories.Owner;
using RealEstateManagement.Data.Repositories.Properties;
using RealEstateManagement.Services.Interfaces;
using RealEstateManagement.Data.Interfaces;

namespace RealEstateManagement
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Configure DI
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();

            // Run the splash form
            using (var scope = ServiceProvider.CreateScope())
            {
                var splashForm = scope.ServiceProvider.GetRequiredService<frmSplash>();
                Application.Run(splashForm);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Logging configuration
            services.AddLogging(config =>
            {
                config.ClearProviders();
                config.AddFile("Logs/RealEstateManagement-{Date}.txt");
                config.SetMinimumLevel(LogLevel.Information);
            });

            // Register repositories
            services.AddScoped<IClientsRepository, ClientsRepository>();

            // Register services
            services.AddScoped<IClientsService, ClientsService>();

            // Register Owners Service
            services.AddScoped<IOwnersService, OwnersService>();

            // Register Owners Repository (if not already registered)
            services.AddScoped<IOwnersRepository, OwnerRepository>();


            // Register Owners Service
            services.AddScoped<IPropertiesService,PropertiesService >();

            // Register Owners Repository (if not already registered)
            services.AddScoped<IPropertiesRepository, PropertiesRepository>();

            // Register forms
            services.AddTransient<frmSplash>();
            services.AddTransient<frmDashboard>();
            services.AddTransient<frmMain>();
            //Clients
            services.AddTransient<frmClients>();
            services.AddTransient<frmEditClient>();
            services.AddTransient<frmClientDetails>();

            //Owners
            services.AddTransient<frmOwners>();
            services.AddTransient<frmEditOwner>();
            services.AddTransient<frmOwnerDetails>();
            services.AddTransient<frmSearchOwner>();

            //Properties
            services.AddTransient<frmPropertiesList>();
            services.AddTransient<frmAddEditProperty>();
            services.AddTransient<frmPropertyDetails>();
        }


    }
}
