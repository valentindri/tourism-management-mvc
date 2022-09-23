using System.ComponentModel.DataAnnotations;

namespace TourismManagement.Models
{
    public class Destination
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Wholesaler> Wholesalers { get; set; }
    }
}
