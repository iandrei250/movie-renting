using System.ComponentModel.DataAnnotations;

namespace Renter.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
