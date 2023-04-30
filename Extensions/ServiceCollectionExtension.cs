using MediatR;
using Microsoft.Extensions.Configuration;
using NetLandApp.Models;
using NetLandApp.NetLandApp.Commands.GetOrder;
using NetLandApp.Services;

namespace NetLandApp.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(GetOrderCommand));
            services.AddScoped<ICsvService, CsvService>();
            services.Configure<CSVSettings>(configuration.GetSection("CSVSettings"));
        }
    }

}
