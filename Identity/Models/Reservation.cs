using System.ComponentModel.DataAnnotations;
namespace Identity.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required]
        public string ReservedRoom {  get; set; }
        [Required]
        public string UserReservation {  get; set; }
        [Required]
        public List<Client> ClientsUsingRoom { get; set; }
        [Required]
        public DateTime SettlementDate { get; set; }
        [Required]
        public DateTime LeavingDate { get; set; }
        [Required]
        public bool BreakfastIncluded { get; set; }
        [Required]
        public bool AllInclusive { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
