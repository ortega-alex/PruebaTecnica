

using AutoMapper;
using BusinessLayer.DTOs.Service;
using BusinessLayer.Interfaces;
using DataLayer.Interfaces;

namespace BusinessLayer.Services
{
    public class ServiceSettingService : IServiceSettingService
    {
        private readonly IServiceSettingRepository _repository;
        private readonly IMapper _mapper;

        public ServiceSettingService(IServiceSettingRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

       
        public async Task<List<ServiceSettingDto>> GetAll()
        {
            var services = await _repository.GetAll();
            return _mapper.Map<List<ServiceSettingDto>>(services);
        }
    }
}
