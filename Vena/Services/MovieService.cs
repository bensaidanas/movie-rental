using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vena.Models;
using Vena.Repositories;
using Vena.ViewModels;

namespace Vena.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repository;

        public MovieService(IMovieRepository repository)
        {
            _repository = repository;
        }
        public void Add(MovieFormViewModel viewModel)
        {
            Movie movie = new Movie
            {
                Name = viewModel.Movie.Name,
                ReleaseDate = viewModel.Movie.ReleaseDate,
                RentalRate = viewModel.Movie.RentalRate,
                NumberInStock = viewModel.Movie.NumberInStock,
                NumberAvailable = viewModel.Movie.NumberAvailable,
                Genre = _repository.GetGenre(viewModel.Movie.GenreId)
            };
            _repository.Add(movie);
        }

        public void Delete(MovieFormViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public MovieFormViewModel Find(int movieId)
        {
            throw new NotImplementedException();
        }

        public IList<MovieInfoViewModel> List()
        {
            IList<Movie> movies = _repository.List().Result;
            return BindCustomerList(movies);
        }

        private IList<MovieInfoViewModel> BindCustomerList(IList<Movie> movies)
        {
            IList<MovieInfoViewModel> moviesViewModel = new List<MovieInfoViewModel>();
            foreach (Movie m in movies)
            {
                moviesViewModel.Add(new MovieInfoViewModel
                {
                    Name = m.Name,
                    ReleaseDate = m.ReleaseDate,
                    Genre = m.Genre,
                    RentalRate = m.RentalRate,
                    NumberInStock = m.NumberInStock,
                    NumberAvailable = m.NumberAvailable
                });
            }
            return moviesViewModel;
        }

        public void Update(MovieFormViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
