using System;

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
        public string Title { get; private set; }
        public int Year { get; private set; }
        public string[] Gender { get; private set; }
        public string[] Country { get; private set; }
        public Guid DirectorId { get; private set; }
    }
}
