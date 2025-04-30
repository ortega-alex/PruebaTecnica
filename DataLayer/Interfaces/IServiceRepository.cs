

using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface IServiceRepository
    {
        Task<List<ServicesResponse>> GetAll(string search = "");
        Task<Service?> GetById(int id);
        Task<Service?> GetByCode(string code);

        Task Add(Service service);
        Task Update(Service service);
        Task<bool> Save();

    }
}
