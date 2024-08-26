using System.ComponentModel.DataAnnotations;

namespace HotelManager.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public required string Name { get; set; }

        [Required]
        public required int Capacity { get; set; }

        [Required]
        public required decimal Price { get; set; }

        public ICollection<Reservation>? Reservations { get; set; }
    }
}
