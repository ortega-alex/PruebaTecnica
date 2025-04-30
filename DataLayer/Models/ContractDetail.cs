
namespace DataLayer.Models
{
    public class ContractDetail:BaseEntity
    {
        public int ContractId { get; set; }
        public Contract Contract { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public decimal Price { get; set; }
        public decimal DisconuntPercentage { get; set; }
        public string BillingFrequency { get; set; }
    }
}
