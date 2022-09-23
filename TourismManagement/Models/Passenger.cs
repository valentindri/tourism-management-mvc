using System.ComponentModel.DataAnnotations;

namespace TourismManagement.Models
{
    public class Passenger
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Name { get; set; }
        public string LastName { get; set; }
        [Required]
        public string IdNum { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
