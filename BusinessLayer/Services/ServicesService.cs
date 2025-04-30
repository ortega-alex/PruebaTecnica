

using AutoMapper;
using BusinessLayer.DTOs.Service;
using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using DataLayer.Models;

namespace BusinessLayer.Services
{
    public class ServicesService:IServicesService
    {
        private readonly IServiceRepository _repository;
        private readonly IMapper _mapper;

        public ServicesService(IServiceRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<string?> Add(CreateServiceDto serviceDto)
        {
            var service = _mapper.Map<Service>(serviceDto);
            await _repository.Add(service);
            var response = await _repository.Save();
            return response ? null : "Ha ocurrido un error";
        }

        public async Task<List<ServiceResponseDto>> GetAll(string search = "")
        {
            var services = await _repository.GetAll(search);
            return _mapper.Map<List<ServiceResponseDto>>(services);
        }

        public async Task<ServiceDto?> GetByCode(string code)
        {
            var service = await _repository.GetByCode(code);
            if (service == null) return null;
            return _mapper.Map<ServiceDto>(service);
        }

        public async Task<string?> Update(UpdateServiceDto serviceDto)
        {
            var service = await _repository.GetById(serviceDto.Id);
            if (service == null) return "No se encontro el servicio";

            service.MonthyCost = serviceDto.MonthyCost;
            service.Description = serviceDto.Description;
            service.ServiceLocationId = serviceDto.ServiceLocationId;
            service.ServiceTypeId = serviceDto.ServiceTypeId;
            service.ServiceSettingId = serviceDto.ServiceSettingId;

            await _repository.Update(service);
            var response = await _repository.Save();
            return response ? null : "Ha ocurrido un error";
        }
    }
}
