using System.ComponentModel.DataAnnotations;

namespace ParkApi.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(40)]
        public string Type { get; set; }
        public string Location { get; set; }
        [Required]
        [Range(1650, 2022, ErrorMessage = "Age must be between 1650 and 2022.")]
        public int YearFounded { get; set; }
        [Required]
        public string Activities { get; set; }
    }
}