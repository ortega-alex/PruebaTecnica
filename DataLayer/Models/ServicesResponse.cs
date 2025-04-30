

namespace DataLayer.Models
{
    public class ServicesResponse
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal MonthyCost { get; set; }
        public bool IsActive { get; set; }
        public int ServiceTypeId { get; set; }
        public string ServiceType { get; set; }
        public int ServiceSettingId { get; set; }
        public string ServiceSetting { get; set; }
        public int ServiceLocationId { get; set; }
        public string City { get; set; }
        public string Zone { get; set; }
    }
}
