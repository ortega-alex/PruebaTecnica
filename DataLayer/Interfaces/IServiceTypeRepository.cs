

using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface IServiceTypeRepository
    {
        Task<List<ServiceType>> GetAll();
    }
}
