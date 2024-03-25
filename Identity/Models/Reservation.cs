using System.ComponentModel.DataAnnotations;
namespace Identity.Models
{
    public class Reservation
    {
        [Required]
        public string ReservedRoom {  get; set; }
        [Required]
        public string UserReservation {  get; set; }
        [Required]
        public List<string> ClientsUsingRoom { get; set; }
        [Required]
        public string SettlementDate { get; set; }
        [Required]
        public string LeavingDate { get; set; }
        [Required]
        public bool BreakfastIncluded { get; set; }
        [Required]
        public bool AllInclusive { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
