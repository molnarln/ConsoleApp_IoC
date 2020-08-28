using System;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp_IoC
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetService<App>().Run();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<App>();
            services.AddSingleton<IContentService, ContentService>();
            services.AddSingleton<IWriter, Writer>();
            return services;
        }
    }
}
