using MediatR;
using NetLandApp.NetLandApp.Commands.GetOrder;
using NetLandApp.Services;

namespace NetLandApp.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(typeof(GetOrderCommand));
            services.AddScoped<ICsvService, CsvService>();
        }
    }

}
