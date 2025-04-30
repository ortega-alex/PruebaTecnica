

using BusinessLayer.DTOs.Service;

namespace BusinessLayer.Interfaces
{
    public interface IServiceTypeService
    {
        Task<List<ServiceTypeDto>> GetAll();
    }
}
