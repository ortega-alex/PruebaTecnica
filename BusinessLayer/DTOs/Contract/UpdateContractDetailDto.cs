

using BusinessLayer.DTOs.Service;

namespace BusinessLayer.DTOs.Contract
{
    public class UpdateContractDetailDto
    {
        public ServiceDto Service { get; set; }
        public decimal Price { get; set; }
        public decimal DisconuntPercentage { get; set; }
        public string BillingFrequency { get; set; }
    }
}
