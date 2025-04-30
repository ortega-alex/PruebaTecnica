

using BusinessLayer.DTOs.Service;
using System.ComponentModel;

namespace Presentation.ViewModel
{
    public class ContractDetailVM
    {
        public ServiceDto Service { get; set; }
        public int ServiceId { get; set; }
        [DisplayName("Servicio")]
        public string ServiceName { get; set; }
        [DisplayName("Tipo de Servicio")]
        public string ServiceType { get; set; }
        
        [DisplayName("Configuracion")]
        public string ServiceSetting { get; set; }

        [DisplayName("Precio")]
        public string Price { get; set; }
        [DisplayName("%Descuento")]
        public string DisconuntPercentage { get; set; }
        [DisplayName("Facturacion")]
        public string BillingFrequency { get; set; }
    }
}
