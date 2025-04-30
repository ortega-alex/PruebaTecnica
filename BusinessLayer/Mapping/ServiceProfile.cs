

using AutoMapper;
using BusinessLayer.DTOs.Service;
using DataLayer.Models;

namespace BusinessLayer.Mapping
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            // MODEL -> DTO
            CreateMap<ServicesResponse, ServiceResponseDto>();
            CreateMap<Service, ServiceDto>();
            CreateMap<ServiceSetting, ServiceSettingDto>();
            CreateMap<ServiceLocation, ServiceLocationDto>();
            CreateMap<ServiceType, ServiceTypeDto>();

            // DTO -> Model
            CreateMap<CreateServiceDto, Service>();
            CreateMap<UpdateServiceDto, Service>();
            CreateMap<ServiceSettingDto, ServiceSetting>();
            CreateMap<ServiceTypeDto, ServiceType>();
            CreateMap<ServiceLocationDto, ServiceLocation>();
        }       
    }
}
