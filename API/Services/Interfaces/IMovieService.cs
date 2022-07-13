using System.Collections.Generic;
using API.Models;
using System;
using System.Threading.Tasks;
using API.ViewModel;
using OperationResults;

namespace API.Services.Interfaces
{
    public interface IMovieService
    {
        public Task<IEnumerable<Movie>> Get(int page, int max);
        public Task<OperationResult> Add(MovieViewModel movieViewModel);
        public Task<bool> Update(Guid movieId);
    }
}
