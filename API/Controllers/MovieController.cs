using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using OperationResults;
using API.ViewModel;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly ILogger<MovieController> _logger;
        private readonly IMovieService _moviesService;
        public MovieController(ILogger<MovieController> logger,
            IMovieService moviesService)
        {
            _logger = logger;
            _moviesService = moviesService ?? throw new ArgumentNullException();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Get()
        {
            var movieList = await _moviesService.GetAll();
            if (movieList.Count() > 0)
            {
                return new OkObjectResult(movieList);
            }
            return new NotFoundResult();
        }

        [HttpGet]
        [Route("/filter")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetByFilter([FromQuery] string filter)
        {
            var movieList = await _moviesService.GetByFilter(filter);
            if (movieList.Count() > 0)
            {
                return new OkObjectResult(movieList);
            }
            return new NotFoundResult();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post(MovieViewModel viewModel)
        {
            var operationResult = await _moviesService.Add(viewModel);
            if(operationResult == OperationResult.SUCCEEDED)
                return new OkResult();
            return new BadRequestResult();
        }
    }
}
