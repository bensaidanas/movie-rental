using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vena.Models
{
    public class Movie : BaseEntity
    {
        [Required]
        [StringLength(255)]
        [Display(Name = "Movie Name")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public Genre Genre { get; set; }

        [ForeignKey("Genre")]
        [Display(Name = "Movie Genre")]
        public int GenreId { get; set; }

        [Required]
        [Display(Name = "Rental Rate")]
        public double RentalRate { get; set; }

        [Range(1, 20)]
        [Display(Name = "Quantity in Stock")]
        public byte NumberInStock { get; set; }
        [Display(Name = "Number Available")]
        public byte NumberAvailable { get; set; }
    }
}
