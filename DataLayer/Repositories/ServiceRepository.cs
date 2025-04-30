

using DataLayer.DataAccess;
using DataLayer.Interfaces;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly ApplicationDbContext _context;

        public ServiceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Service service)
        {
            await _context.AddAsync(service);
        }

        public async Task<List<ServicesResponse>> GetAll(string search = "")
        {
            var services = await _context.Database
                                   .SqlQueryRaw<ServicesResponse>("EXEC sp_services {0}", search)
                                   .ToListAsync();
            return services;
        }

        public async Task<Service?> GetByCode(string code)
        {
            return await _context.Services
              .Include(t => t.ServiceType)
              .Include(l => l.ServiceLocation)
              .Include(s => s.ServiceSetting)
              .FirstOrDefaultAsync(s => s.Code == code);
        }

        public async Task<Service?> GetById(int id)
        {
            return await _context.Services
                .Include(t => t.ServiceType)
                .Include(l => l.ServiceLocation)
                .Include(s => s.ServiceSetting)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task Update(Service service)
        {
            _context.Update(service);
        }
    }
}
