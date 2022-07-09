using API.ViewModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Movie
    {
        public Movie(string title, int year, string[] gender, string[] country, Director director)
        {
            Id = Guid.NewGuid();
            Title = title;
            Year = year;
            Gender = gender;
            Country = country;
            Director = director;
        }
        public Movie(MovieViewModel viewModel, Director director)
        {
            Id = Guid.NewGuid();
            Title = viewModel.Title;
            Year = viewModel.Year;
            Gender = viewModel.Gender;
            Country = viewModel.Country;
            Director = director;
        }
        public Guid Id { get; private set; }
        [Required]
        public string Title { get; private set; }
        [Required]
        public int Year { get; private set; }
        public string[] Gender { get; private set; }
        public string[] Country { get; private set; }
        [Required]
        public Director Director { get; private set; }
    }
}
