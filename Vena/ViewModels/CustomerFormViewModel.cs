using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vena.Models;

namespace Vena.ViewModels
{
    public class CustomerFormViewModel
    {
        [Required]
        [StringLength(255)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Display(Name = "Membership Type")]
        public int MembershipTypeId { get; set; }
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
    }
}
