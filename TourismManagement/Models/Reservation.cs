using System.ComponentModel.DataAnnotations;

namespace TourismManagement.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public ICollection<Passenger> Passengers { get; set; }
        [Required]
        public int DestinationId { get; set; }
        [Required]
        public int WholesalerId { get; set; }
        [Required]
        public DateTime DepartureDate { get; set; }
        public string HotelName { get; set; }
        [Required]
        public int NumberOfNights { get; set; }
        public int RoomsNbr { get; set; }
        [Required]
        public float TotalCost { get; set; }
        public string Vehicle { get; set; }
        public string Comments { get; set; }
    }
}
