

using BusinessLayer.DTOs.Service;

namespace BusinessLayer.Interfaces
{
    public interface IServicesService
    {
        Task<List<ServiceResponseDto>> GetAll(string search = "");
        Task<ServiceDto?> GetByCode(string code);
        Task<string?> Add(CreateServiceDto serviceDto);
        Task<string?> Update(UpdateServiceDto serviceDto);
    }
}
