using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using API.Models;
using API.Services.Interfaces;
using System.Net;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly ILogger<MoviesController> _logger;
        private readonly IMoviesService _moviesService;
        public MoviesController(ILogger<MoviesController> logger,
            IMoviesService moviesService)
        {
            _logger = logger;
            _moviesService = moviesService ?? throw new ArgumentNullException();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var movieList = _moviesService.GetAll();
            return new OkObjectResult(movieList);
        }
    }
}
