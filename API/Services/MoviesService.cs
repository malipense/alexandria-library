using System;
using System.Collections.Generic;
using API.Models;
using API.Services.Interfaces;

namespace API.Services
{
    public class MoviesService : IMoviesService
    {
        private List<Movie> _mockedMovies = new List<Movie> 
        {
            new Movie("The Godfather", 1990, new string[] { "Crime" }, new string[] { "USA", "Italy" }, new Director())
        };
        public bool Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAll()
        {
            return _mockedMovies;
        }

        public IEnumerable<Movie> GetByFilter()
        {
            throw new NotImplementedException();
        }

        public bool Update(Guid movieId)
        {
            throw new NotImplementedException();
        }
    }
}
