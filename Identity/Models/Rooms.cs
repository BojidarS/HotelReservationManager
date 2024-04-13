using System.ComponentModel.DataAnnotations;
namespace Identity.Models
{
    public class Rooms
    {
        public int Id { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public bool IsOccupied { get; set; }
        [Required]
        public double PriceForAdult { get; set; }
        [Required]
        public double PriceForChild { get; set; }
        [Required]
        public int Number { get; set; }
    }
}
