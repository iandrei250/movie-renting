using Renter.Models;
using System.ComponentModel.DataAnnotations;

namespace Renter.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool isSubcribedToNewsletter { get; set; }
      
        public byte MembershipTypeId { get; set; }

        public string? Birthday { get; set; }
    }
}
