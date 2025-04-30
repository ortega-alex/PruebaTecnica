

using AutoMapper;
using BusinessLayer.DTOs.Service;
using BusinessLayer.Interfaces;
using DataLayer.Interfaces;

namespace BusinessLayer.Services
{
    public class ServiceTypeService : IServiceTypeService
    {
        private readonly IServiceTypeRepository _repository;
        private readonly IMapper _mapper;

        public ServiceTypeService(IServiceTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

       
        public async Task<List<ServiceTypeDto>> GetAll()
        {
            var services = await _repository.GetAll();
            return _mapper.Map<List<ServiceTypeDto>>(services);
        }
    }
}
