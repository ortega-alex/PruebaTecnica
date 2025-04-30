

using BusinessLayer.DTOs.Service;

namespace BusinessLayer.Interfaces
{
    public interface IServiceSettingService
    {
        Task<List<ServiceSettingDto>> GetAll();
    }
}
