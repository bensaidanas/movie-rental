using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vena.Models
{
    public class Rental : BaseEntity
    {
        public Movie Movie { get; set; }
        public Customer Customer { get; set; }
        public double Total { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
