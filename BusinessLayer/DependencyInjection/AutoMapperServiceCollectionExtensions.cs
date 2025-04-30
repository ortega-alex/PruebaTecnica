

using BusinessLayer.Mapping;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.DependencyInjection
{
    public static class AutoMapperServiceCollectionExtensions
    {
        public static void AddAutoMapperService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CustomerProfile).Assembly);
            services.AddAutoMapper(typeof(ServiceProfile).Assembly);
            services.AddAutoMapper(typeof(ContractProfile).Assembly);
        }
    }
}
