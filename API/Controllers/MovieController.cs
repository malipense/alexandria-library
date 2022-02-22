using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using API.Models;
using API.Services.Interfaces;
using System.Net;
using Microsoft.AspNetCore.Http;

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
            return new OkObjectResult(movieList);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetByFilter(string parameters)
        {
            var movieList = await _moviesService.GetByFilter();
            return new OkObjectResult(movieList);
        }
    }
}
