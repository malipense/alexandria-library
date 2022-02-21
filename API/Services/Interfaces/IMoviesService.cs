using System.Collections.Generic;
using API.Models;
using System;

namespace API.Services.Interfaces
{
    public interface IMoviesService
    {
        public IEnumerable<Movie> GetAll();
        public IEnumerable<Movie> GetByFilter();
        public bool Add(Movie movie);
        public bool Update(Guid movieId);
    }
}
