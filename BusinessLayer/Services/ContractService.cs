

using AutoMapper;
using BusinessLayer.DTOs.Contract;
using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using DataLayer.Models;

namespace BusinessLayer.Services
{
    public class ContractService: IContractService
    {
        private readonly IContractRepository _repository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public ContractService(IContractRepository repository, IMapper mapper, ICustomerRepository customerRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<string?> Add(CreateContractDto contractDto)
        {
            var customer = await _customerRepository.GetById(contractDto.CustomerId);
            if (customer == null) return "El cliente no exite";

            var contract = _mapper.Map<Contract>(contractDto);
            var response = await _repository.Add(contract);
            return response ? null : "Ha ocurrido un error";
        }

        public async Task<List<ContractDto>> GetAll(string search = "")
        {
            var contracts = await _repository.GetAll(search);
            return _mapper.Map<List<ContractDto>>(contracts);
        }

        public async Task<string?> Update(UpdateContractDto contractDto)
        {
            var contract = await _repository.GetById(contractDto.Id);
            if (contract == null) return "No se encontro el contrato";

            contract.StartDate = contractDto.StartDate;
            contract.EndDate = contractDto.EndDate;
            contract.CustomerId = contractDto.CustomerId;
            contract.ContractDetails = _mapper.Map<List<ContractDetail>>(contractDto.ContractDetails);

            var response =  await _repository.Update(contract);
            return response ? null : "Ha ocurrido un error";
        }
    }
}
