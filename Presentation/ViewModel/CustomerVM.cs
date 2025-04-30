
using System.ComponentModel;

namespace Presentation.ViewModel
{
    public class CustomerVM
    {
        public int Id { get; set; }
        [DisplayName("Nombre")]
        public string Name { get; set; }
        [DisplayName("Codigo")]
        public string Code { get; set; }
        [DisplayName("Direccion")]
        public string Address { get; set; }
        [DisplayName("Correo")]
        public string Email { get; set; }
        [DisplayName("Numero de Telefono")]
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        [DisplayName("Habilitado")]
        public string Enabled { get; set; }
    }
}
