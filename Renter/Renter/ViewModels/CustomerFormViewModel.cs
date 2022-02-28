using Renter.Models;
using System.Collections.Generic;

namespace Renter.ViewModels
{
    public class CustomerFormViewModel
    {

        public List<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}
