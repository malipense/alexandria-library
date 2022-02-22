using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;
using API.Services.Interfaces;

namespace API.Services
{
    public class MovieService : IMovieService
    {
        private List<Movie> _mockedMovies = new List<Movie> 
        {
            new Movie("The Godfather", 1990, new string[] { "Crime" }, new string[] { "USA", "Italy" }, new Director())
        };
        public bool Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> GetAll()
        {
            return Task.FromResult((IEnumerable<Movie>)_mockedMovies);
        }

        public Task<IEnumerable<Movie>> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public bool Update(Guid movieId)
        {
            throw new NotImplementedException();
        }
    }
}
