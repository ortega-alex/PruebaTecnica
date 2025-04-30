

using AutoMapper;
using BusinessLayer.DTOs.Customer;
using DataLayer.Models;

namespace BusinessLayer.Mapping
{
    public class CustomerProfile: Profile
    {
        public CustomerProfile()
        {
            // MODEL -> DTO
            CreateMap<Customer, CustomerDto>();

            // DTO -> Model
            CreateMap<CreateCustomerDto, Customer>();
            CreateMap<UpdateCustomerDto, Customer>();
        }       
    }
}
