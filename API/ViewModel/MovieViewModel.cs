using System;
using System.ComponentModel.DataAnnotations;

namespace API.ViewModel
{
    public class MovieViewModel
    {
        public MovieViewModel(string title, int year, string[] gender, string[] country, Guid directorId)
        {
            Title = title;
            Year = year;
            Gender = gender;
            Country = country;
            DirectorId = directorId;
        }
        [Required]
        public string Title { get; private set; }
        [Required]
        public int Year { get; private set; }
        [Required]
        public string[] Gender { get; private set; }
        [Required]
        public string[] Country { get; private set; }
        [Required]
        public Guid DirectorId { get; private set; }
    }
}
