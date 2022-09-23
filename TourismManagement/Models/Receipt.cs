using System.ComponentModel.DataAnnotations;

namespace TourismManagement.Models
{
    public class Receipt
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ReservationId { get; set; }

        public int? PassengerId { get; set; }

    }
}
