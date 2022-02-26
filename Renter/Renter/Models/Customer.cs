using System.ComponentModel.DataAnnotations;

namespace Renter.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool isSubcribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }

        public string? Birthday { get; set; }
    }
}
