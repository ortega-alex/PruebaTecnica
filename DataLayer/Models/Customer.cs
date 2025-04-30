

using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
    public class Customer: BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
       
    }
}
