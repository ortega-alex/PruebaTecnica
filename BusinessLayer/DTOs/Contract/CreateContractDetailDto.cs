


using BusinessLayer.DTOs.Service;

namespace BusinessLayer.DTOs.Contract
{
    public class CreateContractDetailDto
    {
        public int ServiceId { get; set; }
        public decimal Price { get; set; }
        public decimal DisconuntPercentage { get; set; }
        public string BillingFrequency { get; set; }
    }
}
