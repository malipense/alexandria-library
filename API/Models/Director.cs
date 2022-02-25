using System;

namespace API.Models
{
    public class Director
    {
        public Director(string name, DateTime dateOfBirth, string nationality)
        {
            Id = Guid.NewGuid();
            Name = name;
            DateOfBirth = dateOfBirth;
            Nationality = nationality;
        }
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Nationality { get; private set; }
    }
}
