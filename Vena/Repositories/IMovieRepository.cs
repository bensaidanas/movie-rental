using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vena.Models;

namespace Vena.Repositories
{
    public interface IMovieRepository
    {
        Task<IList<Movie>> List();
        Genre GetGenre(int id);
        Movie Find();
        void Add(Movie movie);
        void Update(Movie movie);
        void Delete(Movie movie);
    }
}
