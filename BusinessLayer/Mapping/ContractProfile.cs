

using AutoMapper;
using BusinessLayer.DTOs.Contract;
using DataLayer.Models;

namespace BusinessLayer.Mapping
{
    public class ContractProfile: Profile
    {
        public ContractProfile()
        {

            // MODEL -> DTO
            CreateMap<Contract, ContractDto>();
            CreateMap<ContractDetail, ContractDetailDto>();

            // DTO -> Model
            CreateMap<CreateContractDto, Contract>();
                   // .ForMember(dest => dest.ContractDetails, opt => opt.MapFrom(src => src.ContractDetails));
            CreateMap<UpdateContractDto, Contract>();
            CreateMap<CreateContractDetailDto, ContractDetail>();
                 // .ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<UpdateContractDetailDto, ContractDetail>();
        }
    }
}
