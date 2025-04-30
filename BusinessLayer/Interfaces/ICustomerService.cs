

using BusinessLayer.DTOs.Customer;
using DataLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface ICustomerService
    {
        Task<List<CustomerDto>> GetAll(string search = "");
        Task<string?> Add(CreateCustomerDto customerDto);
        Task<string?> Update(UpdateCustomerDto customerDto);
    }
}
