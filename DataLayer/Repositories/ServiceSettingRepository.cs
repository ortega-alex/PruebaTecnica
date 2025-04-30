

using DataLayer.DataAccess;
using DataLayer.Interfaces;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class ServiceSettingRepository : IServiceSettingRepository
    {
        private readonly ApplicationDbContext _context;

        public ServiceSettingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ServiceSetting>> GetAll()
        {
            var services = await _context.ServiceSettings.ToListAsync();
            return services;
        }     
    }
}
