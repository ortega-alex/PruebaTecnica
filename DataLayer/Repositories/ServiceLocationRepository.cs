

using DataLayer.DataAccess;
using DataLayer.Interfaces;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class ServiceLocationRepository : IServiceLocationRepository
    {
        private readonly ApplicationDbContext _context;

        public ServiceLocationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ServiceLocation>> GetAll()
        {
            var services = await _context.ServiceLocations.ToListAsync();
            return services;
        }     
    }
}
