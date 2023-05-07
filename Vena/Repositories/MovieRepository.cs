using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vena.Data;
using Vena.Models;

namespace Vena.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly VenaDbContext _context;

        public MovieRepository(VenaDbContext context)
        {
            _context = context;
        }
        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void Delete(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Movie Find()
        {
            throw new NotImplementedException();
        }

        public Genre GetGenre(int id)
        {
            return _context.Genres.Find(id);
        }

        public async Task<IList<Movie>> List()
        {
            return await _context.Movies.Include(m => m.Genre).ToListAsync();
        }

        public void Update(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
