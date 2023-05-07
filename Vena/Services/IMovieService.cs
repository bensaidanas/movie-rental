using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vena.ViewModels;

namespace Vena.Services
{
    public interface IMovieService
    {
        IList<MovieInfoViewModel> List();
        MovieFormViewModel Find(int movieId);
        void Add(MovieFormViewModel viewModel);
        void Update(MovieFormViewModel viewModel);
        void Delete(MovieFormViewModel viewModel);
    }
}
