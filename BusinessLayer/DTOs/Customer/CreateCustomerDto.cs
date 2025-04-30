
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs.Customer
{
    public class CreateCustomerDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(45)]
        public string Code { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
