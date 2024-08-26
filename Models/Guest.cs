using System.ComponentModel.DataAnnotations;

namespace HotelManager.Models
{
    public class Guest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string Name { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [Phone]
        public required string Phone { get; set; }

        // Navigation property for related reservations
        public ICollection<Reservation>? Reservations { get; set; }
    }
}
