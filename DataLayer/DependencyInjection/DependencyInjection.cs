using DataLayer.Interfaces;
using DataLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayer.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void RegisterRepositoryDependecies(this IServiceCollection services)
        {
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IServiceTypeRepository, ServiceTypeRepository>();
            services.AddTransient<IServiceLocationRepository, ServiceLocationRepository>();
            services.AddTransient<IServiceSettingRepository, ServiceSettingRepository>();
            services.AddTransient<IContractRepository, ContractRepository>();
        }
    }
}
