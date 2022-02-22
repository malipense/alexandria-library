using System.Collections.Generic;
using API.Models;
using System;
using System.Threading.Tasks;

namespace API.Services.Interfaces
{
    public interface IMovieService
    {
        public Task<IEnumerable<Movie>> GetAll();
        public Task<IEnumerable<Movie>> GetByFilter();
        public bool Add(Movie movie);
        public bool Update(Guid movieId);
    }
}
