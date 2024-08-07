using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace PruebaC_sharp_MariaJosePino.Models
{
    public class Driver : User
    {
        public string? LicenseNumber { get; set; }
        public string? LicenseCategory { get; set; }
        public int DrivingExperience { get; set; }

        public Driver(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string address, string licenseNumber, string licenseCategory, int drivingExperience) : base(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address)
        {
            LicenseNumber = licenseNumber;
            LicenseCategory = licenseCategory;
            DrivingExperience = drivingExperience;
        }

        public string? GetName()
        {
            return Name;
        }
        public string? GetLastName()
        {
            return LastName;
        }
        public string? GetTypeDocument()
        {
            return TypeDocument;
        }
        public string? GetIdentificationNumber()
        {
            return IdentificationNumber;
        }
        public DateOnly GetBirthDate()
        {
            return BirthDate;
        }
        public string? GetEmail()
        {
            return Email;
        }
        public string? GetPhoneNumber()
        {
            return PhoneNumber;
        }
        public string? GetAddress()
        {
            return Address;
        }

        public int ReturnAge()
        {
            int Age = CalculateAge();
            return Age;
        }


        public void UpdateLicenseCategory(string newCategory)
        {
            LicenseCategory = newCategory;
        }

        public void AddExperience(int years)
        {
            DrivingExperience = years;
        }
    }
}