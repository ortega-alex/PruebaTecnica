

namespace DataLayer.Models
{
    public class Service:BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal MonthyCost { get; set; }
        public int ServiceLocationId { get; set; }
        public ServiceLocation ServiceLocation { get; set; }
        public int ServiceTypeId { get; set; }
        public ServiceType ServiceType { get; set; }
        public int ServiceSettingId { get; set; }
        public ServiceSetting ServiceSetting { get; set; }
    }
}
