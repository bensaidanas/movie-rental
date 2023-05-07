using System.ComponentModel.DataAnnotations;

namespace Vena.Models
{
    public class MembershipType : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public short SignUpFee { get; set; }
        [Required]
        public byte DurationInMonth { get; set; }
        [Required]
        public byte DiscountRate { get; set; }
    }
}