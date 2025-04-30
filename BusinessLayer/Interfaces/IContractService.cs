

using BusinessLayer.DTOs.Contract;

namespace BusinessLayer.Interfaces
{
    public interface IContractService
    {
        Task<List<ContractDto>> GetAll(string search = "");
        Task<string?> Add(CreateContractDto contractDto);
        Task<string?> Update(UpdateContractDto contractDto);
    }
}
