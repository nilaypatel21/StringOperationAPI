using Microsoft.Extensions.DependencyInjection;
using Project.Core.BusinessServices;
using Project.Core.BusinessServices.Implementation;

namespace Project.Core.Extentions
{
    public static class ServiceCollectionExtention
    {
        /// <summary>
        /// Extention method to register all business services.
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IStringOperationService, StringOperationService>();
        }
    }
}
