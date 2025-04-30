

using DataLayer.DataAccess;
using DataLayer.Interfaces;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class ServiceTypeRepository : IServiceTypeRepository
    {
        private readonly ApplicationDbContext _context;

        public ServiceTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ServiceType>> GetAll()
        {
            var services = await _context.ServiceTypes.ToListAsync();
            return services;
        }     
    }
}
