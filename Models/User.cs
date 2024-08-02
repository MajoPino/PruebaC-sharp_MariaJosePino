using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_MariaJosePino.Models;

    public class User
    {
        protected Guid Id { get; set; }
        protected string? Name { get; set; }
        protected string? LastName { get; set; }
        protected string? TypeDocument { get; set; }
        protected string? IdentificationNumber { get; set; }
        protected DateOnly BirthDate { get; set; }
        protected string? Email { get; set; }
        protected string? PhoneNumber { get; set; }
        protected string? Address { get; set; }

        protected User(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string address)
        {
            Id = new Guid();
            Name = name;
            LastName = lastName;
            TypeDocument = typeDocument;
            IdentificationNumber = identificationNumber;
            BirthDate = birthDate;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }


        protected void ShowDetails()
        {
            Console.WriteLine(@$"Full Name: {Name} {LastName}
Identification Number: {TypeDocument} {IdentificationNumber}
Birth Date: {BirthDate.Year}
Email: {Email}
Phone Number: {PhoneNumber}
Address: {Address}
");
        }

        protected int CalculateAge()
        {
            int birthDateYear = BirthDate.Year;
            int thisYear = DateTime.Now.Year;

            int age = birthDateYear - thisYear;

            return age;

        }

        protected void ShowAge()
        {
            int age = CalculateAge();
            Console.WriteLine(@$"The user {Name} {LastName} is {age} years old.");
        }
    }
