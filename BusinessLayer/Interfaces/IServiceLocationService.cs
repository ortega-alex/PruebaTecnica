

using BusinessLayer.DTOs.Service;

namespace BusinessLayer.Interfaces
{
    public interface IServiceLocationService
    {
        Task<List<ServiceLocationDto>> GetAll();
    }
}
