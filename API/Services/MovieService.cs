using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;
using API.Services.Interfaces;
using System.Linq;
using API.ViewModel;
using OperationResults;

namespace API.Services
{
    public class MovieService : IMovieService
    {
        private List<Movie> _mockedMovies = new List<Movie> 
        {
            new Movie("The Godfather", 1990, new string[] { "Crime", "Policial" }, new string[] { "USA", "Italy" }, new Director("Ingman Bergman", DateTime.UtcNow, "Swedish")),
            new Movie("Seventh Seal", 1968, new string[] { "Fantasy" }, new string[] { "Sweden" }, new Director("Ingman Bergman", DateTime.UtcNow, "Swedish"))
        };

        private List<Director> _mockedDirectors = new List<Director>
        {
            new Director("Alfred Hitcock", DateTime.UtcNow, "English")
        };

        public Task<OperationResult> Add(MovieViewModel movieViewModel)
        {
            var result = OperationResult.UNRESULTED;

            var movie = _mockedMovies.FirstOrDefault(f => 
                f.Title == movieViewModel.Title
                && f.Year == movieViewModel.Year);

            if (movie != null)
                return Task.FromResult(OperationResult.ITEM_EXISTS);

            var director = _mockedDirectors.FirstOrDefault(f => f.Id == movieViewModel.DirectorId);
            var movieToAdd = new Movie(movieViewModel, director);
            try
            {
                _mockedMovies.Add(movieToAdd);
                result = OperationResult.SUCCEEDED;
            }
            catch (Exception e)
            {
                result = OperationResult.FAILED;
            }
            return Task.FromResult(result);
        }

        public Task<IEnumerable<Movie>> Get(int page, int max)
        {
            return Task.FromResult((IEnumerable<Movie>)_mockedMovies);
        }

        public Task<bool> Update(Guid movieId)
        {
            throw new NotImplementedException();
        }
    }
}
