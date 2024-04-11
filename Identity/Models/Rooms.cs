using System.ComponentModel.DataAnnotations;
namespace Identity.Models
{
    public class Rooms
    {
        [Required]
        public int Capacity { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public bool IsOccupied { get; set; }
        [Required]
        public int PriceForAdult { get; set; }
        [Required]
        public int PriceForChild { get; set; }
        [Required]
        public int Number { get; set; }
    }
}
