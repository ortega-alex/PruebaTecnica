

using BusinessLayer.DTOs.Customer;

namespace BusinessLayer.DTOs.Contract
{
    public class ContractDto
    {
        public CustomerDto Customer { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PayPeriod { get; set; }
        public decimal DisconuntPercentage { get; set; }
        public List<ContractDetailDto> ContractDetails { get; set; }
    }
}
