
using System.ComponentModel;

namespace Presentation.ViewModel
{
    public class ServiceVM
    {
        public int Id { get; set; }
        [DisplayName("Codigo")]
        public string Code { get; set; }
        [DisplayName("Descripcion")]
        public string Description { get; set; }
        [DisplayName("Mensualidad")]
        public decimal MonthyCost { get; set; }

        public int ServiceLocationId { get; set; }
        public string City { get; set; }
        public string Zone { get; set; }
        [DisplayName("Ubicacion")]
        public string Location { get; set; }

        public int ServiceTypeId { get; set; }

        [DisplayName("Tipo de Servicio")]
        public string ServiceType { get; set; }

        public int ServiceSettingId { get; set; }

        [DisplayName("Configuracion")]
        public string ServiceSetting { get; set; }

        public bool IsActive { get; set; }
        [DisplayName("Habilitado")]
        public string Enabled { get; set; }
    }
}
