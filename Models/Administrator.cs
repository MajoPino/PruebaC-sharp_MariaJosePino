using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_MariaJosePino.Models;
public class Administrator
{
    public List<Driver> Drivers = new List<Driver>();
    public List<Customer> Customers = new List<Customer>();
    public List<Vehicle> Vehicles = new List<Vehicle>();

    public void AddDriver(Driver driver)
    {
        Drivers.Add(driver);
    }

    public void AddCustomer(Customer customer)
    {
        Customers.Add(customer);
    }

    public void ShowDriversInfo()
    {
        foreach (var Driver in Drivers)
        {
            string? name = Convert.ToString(Driver.GetName());
            string? lastname = Convert.ToString(Driver.GetLastName());
            string? typeDocument = Convert.ToString(Driver.GetTypeDocument());
            string? identificationNumber = Convert.ToString(Driver.GetIdentificationNumber());
            string? birthDate = Convert.ToString(Driver.GetBirthDate());
            string? email = Convert.ToString(Driver.GetEmail());
            string? phone = Convert.ToString(Driver.GetPhoneNumber());
            string? address = Convert.ToString(Driver.GetAddress());

            Console.WriteLine(@$"
Driver's Name: {name} {lastname}
Identification Document: {typeDocument} {identificationNumber}
Birth Date: {birthDate}
Email: {email}
Phone Number: {phone}
Address: {address}
License: {Driver.LicenseCategory} {Driver.LicenseNumber}
Driving Experience: {Driver.DrivingExperience} years
");
        }
    }

    public void ShowCustomersInfo()
    {
        foreach (var Customer in Customers)
        {
            string? name = Convert.ToString(Customer.GetName());
            string? lastname = Convert.ToString(Customer.GetLastName());
            string? typeDocument = Convert.ToString(Customer.GetTypeDocument());
            string? identificationNumber = Convert.ToString(Customer.GetIdentificationNumber());
            string? birthDate = Convert.ToString(Customer.GetBirthDate());
            string? email = Convert.ToString(Customer.GetEmail());
            string? phone = Convert.ToString(Customer.GetPhoneNumber());
            string? address = Convert.ToString(Customer.GetAddress());

            Console.WriteLine(@$"
Driver's Name: {name} {lastname}
Identification Document: {typeDocument} {identificationNumber}
Birth Date: {birthDate}
Email: {email}
Phone Number: {phone}
Address: {address}
Membership Level: {Customer.MembershipLevel}
Preferred Payment Method: {Customer.PreferredPaymentMethod}
");
        }
    }



    public void AddVehicle(Vehicle vehicle)
    {
        Vehicles.Add(vehicle);
    }
}
