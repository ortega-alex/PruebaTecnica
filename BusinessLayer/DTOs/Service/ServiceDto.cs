

namespace BusinessLayer.DTOs.Service
{
    public class ServiceDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal MonthyCost { get; set; }
        public bool IsActive { get; set; }

        public ServiceLocationDto ServiceLocation { get; set; }
        public ServiceTypeDto ServiceType { get; set; }
        public ServiceSettingDto ServiceSetting { get; set; }
    }
}
