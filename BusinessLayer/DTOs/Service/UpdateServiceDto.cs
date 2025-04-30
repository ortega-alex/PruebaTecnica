

using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs.Service
{
    public class UpdateServiceDto
    {
        public string Code { get; set; }
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(2500)]
        public string Description { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public decimal MonthyCost { get; set; }
        public bool IsActive { get; set; }

        [Required]
        public int ServiceLocationId { get; set; }
        [Required]
        public int ServiceTypeId { get; set; }
        [Required]
        public int ServiceSettingId { get; set; }
    }
}
