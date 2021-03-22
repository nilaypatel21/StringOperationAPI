using Microsoft.Extensions.DependencyInjection;
using Project.Core.BusinessServices;
using Project.Core.BusinessServices.Implementation;

namespace Project.Core.Extentions
{
    public static class ServiceCollectionExtention
    {
        public static void RegisterBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IStringOperationService, StringOperationService>();
        }
    }
}
