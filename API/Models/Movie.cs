using System;

namespace API.Models
{
    public class Movie
    {
        public Movie(string title, int year, string[] gender, string[] country, Director director)
        {
            Id = new Guid();
            Title = title;
            Year = year;
            Gender = gender;
            Country = country;
            Director = director;
        }
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public int Year { get; private set; }
        public string[] Gender { get; private set; }
        public string[] Country { get; private set; }
        public Director Director { get; private set; }
    }
}
