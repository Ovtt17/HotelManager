using System.ComponentModel.DataAnnotations;

namespace HotelManager.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }

        [Required]
        [StringLength(50)]
        public required string RoomType { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public required decimal PricePerNight { get; set; }

        // Navigation property for related reservations
        [Required]
        public ICollection<Reservation>? Reservations { get; set; }
    }
}
