

using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface IServiceLocationRepository
    {
        Task<List<ServiceLocation>> GetAll();
    }
}
