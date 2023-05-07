using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vena.Models;

namespace Vena.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}
