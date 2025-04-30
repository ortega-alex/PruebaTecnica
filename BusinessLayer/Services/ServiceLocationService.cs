

using AutoMapper;
using BusinessLayer.DTOs.Service;
using BusinessLayer.Interfaces;
using DataLayer.Interfaces;

namespace BusinessLayer.Services
{
    public class ServiceLocationService : IServiceLocationService
    {
        private readonly IServiceLocationRepository _repository;
        private readonly IMapper _mapper;

        public ServiceLocationService(IServiceLocationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

       
        public async Task<List<ServiceLocationDto>> GetAll()
        {
            var services = await _repository.GetAll();
            return _mapper.Map<List<ServiceLocationDto>>(services);
        }
    }
}
