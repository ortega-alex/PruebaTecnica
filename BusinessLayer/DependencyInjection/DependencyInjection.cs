using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayer.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void RegisterServiceDependecies(this IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IServicesService, ServicesService>();
            services.AddTransient<IServiceTypeService, ServiceTypeService>();
            services.AddTransient<IServiceSettingService, ServiceSettingService>();
            services.AddTransient<IServiceLocationService, ServiceLocationService>();
            services.AddTransient<IContractService, ContractService>();
        }
    }
}
