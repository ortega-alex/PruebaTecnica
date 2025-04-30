

using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAll(string search = "");
        Task<Customer?> GetById(int id);
        Task Add(Customer customer);
        Task Update(Customer customer);
        Task<bool> Save();

    }
}
