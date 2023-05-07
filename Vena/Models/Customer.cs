using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vena.Models
{
    public class Customer : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public MembershipType MembershipType { get; set; }

        [ForeignKey("MembershipType")]
        public int MembershipTypeId { get; set; }

        public DateTime MembershipEndDate { get; set; }
    }
}
