using System.ComponentModel.DataAnnotations;

namespace TourismManagement.Models
{
    public class Wholesaler
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Destination> Destinations { get; set; }
    }
}
