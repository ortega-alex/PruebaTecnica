

using AutoMapper;
using BusinessLayer.DTOs.Customer;
using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using DataLayer.Models;

namespace BusinessLayer.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<string?> Add(CreateCustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            await _repository.Add(customer);
            var response = await _repository.Save();
            return response ? null : "Ha ocurrido un error";
        }

        public async Task<List<CustomerDto>> GetAll(string search = "")
        {
            var customers = await _repository.GetAll(search);
            return _mapper.Map<List<CustomerDto>>(customers);
        }

        public async Task<string?> Update(UpdateCustomerDto customerDto)
        {
            var customer = await _repository.GetById(customerDto.Id);
            if (customer == null) return "Cliente no encontrado";

            customer.Name = customerDto.Name;
            customer.Code = customerDto.Code;
            customer.Email = customerDto.Email;
            customer.Address = customerDto.Address;
            customer.PhoneNumber  = customerDto.PhoneNumber;
            customer.IsActive = customerDto.IsActive;

            await _repository.Update(customer);
            var response = await _repository.Save();
            return response ? null : "Ha ocurrido un error";
        }
    }
}
