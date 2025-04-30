

using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface IContractRepository
    {
        Task<List<Contract>> GetAll(string search = "");
        Task<Contract?> GetById(int id);
        Task<bool> Add(Contract contract);
        Task<bool> Update(Contract contract);
    }
}
