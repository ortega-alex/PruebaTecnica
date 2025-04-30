

namespace DataLayer.Models
{
    public class Contract:BaseEntity
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PayPeriod { get; set; }
        public decimal DisconuntPercentage { get; set; }
        public ICollection<ContractDetail> ContractDetails { get; set; } = new List<ContractDetail>();
    }
}
