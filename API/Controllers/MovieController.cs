using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using API.Services.Interfaces;
using OperationResults;
using API.ViewModel;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using System.Net.Mime;
using System.Collections.Generic;
using API.lib;

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
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        [ResponseCache(Duration = 43200)]
        public async Task<ActionResult<IEnumerable<Movie>>> Get([FromQuery] int page = 1, int max = 20)
        {
            var movieList = await _moviesService.Get(page, max);
            if (movieList.Count() <= 0)
            {
                return NotFound();
            }

            this.GenerateLinks();
            return movieList.ToList();
        }

        [HttpOptions]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(200)]
        [ResponseCache(Duration = 3600)]
        public async Task<IActionResult> Options()
        {
            string[] operations = { "GET", "POST" };
            Response.Headers.Add("Allow", operations);
            
            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Post(MovieViewModel viewModel)
        {
            var operationResult = await _moviesService.Add(viewModel);
            if(operationResult == OperationResult.SUCCEEDED)
                return new OkResult();
            return new BadRequestResult();
        }
    }
}
