using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Vena.Models;

namespace Vena.ViewModels
{
    public class ListCustomerViewModel : BaseEntity
    { 
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        [Display(Name = "Membership Type")]
        public MembershipType MembershipType { get; set; }
    }
}
