


namespace BusinessLayer.DTOs.Contract
{
    public class CreateContractDto
    {
        public int CustomerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PayPeriod { get; set; }
        public decimal DisconuntPercentage { get; set; }
        public List<CreateContractDetailDto> ContractDetails { get; set; }
    }
}
