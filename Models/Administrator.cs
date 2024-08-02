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
Customer's Name: {name} {lastname}
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

    public void SearchDriver()
    {
        Console.Write("Please, enter the document number of the driver you want to search: ");
        string? identificationNumberInput = Console.ReadLine();
        var driver = Drivers.FirstOrDefault(x => x.GetIdentificationNumber() == identificationNumberInput);
        if (driver != null)
        {
            string? name = Convert.ToString(driver.GetName());
            string? lastname = Convert.ToString(driver.GetLastName());
            string? typeDocument = Convert.ToString(driver.GetTypeDocument());
            string? identificationNumber = Convert.ToString(driver.GetIdentificationNumber());
            string? birthDate = Convert.ToString(driver.GetBirthDate());
            string? email = Convert.ToString(driver.GetEmail());
            string? phone = Convert.ToString(driver.GetPhoneNumber());
            string? address = Convert.ToString(driver.GetAddress());

            Console.WriteLine(@$"
Driver's Name: {name} {lastname}
Identification Document: {typeDocument} {identificationNumber}
Birth Date: {birthDate}
Email: {email}
Phone Number: {phone}
Address: {address}
License: {driver.LicenseCategory} {driver.LicenseNumber}
Driving Experience: {driver.DrivingExperience} years
");
        }
        else
        {
            Console.WriteLine(@$"The driver with the document number {identificationNumberInput} does not exist, please verify the information and try again.");
        }
    }

    public void SearchCustomer()
    {
        Console.Write("Please, enter the document number of the customer you want to search: ");
        string? identificationNumberInput = Console.ReadLine();
        var Customer = Customers.FirstOrDefault(x => x.GetIdentificationNumber() == identificationNumberInput);
        if (Customer != null)
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
Customer's Name: {name} {lastname}
Identification Document: {typeDocument} {identificationNumber}
Birth Date: {birthDate}
Email: {email}
Phone Number: {phone}
Address: {address}
Membership Level: {Customer.MembershipLevel}
Preferred Payment Method: {Customer.PreferredPaymentMethod}
");
        }
        else
        {
            Console.WriteLine(@$"The customer with the document number {identificationNumberInput} does not exist, please verify the information and try again.");
        }
    }

    public void DeleteDriver()
    {
        Console.Write("Please, enter the document number of the driver you want to delete: ");
        string? identificationNumberInput = Console.ReadLine();
        var driver = Drivers.FirstOrDefault(x => x.GetIdentificationNumber() == identificationNumberInput);

        if (driver != null)
        {
            Drivers.Remove(driver);
            Console.WriteLine(@"
The driver has been deleted successfully!");
        }
        else
        {
            Console.WriteLine(@$"The driver with the document number {identificationNumberInput} does not exist, please verify the information and try again.");
        }
    }

    public void DeleteCustomer()
    {
        Console.Write("Please, enter the document number of the customer you want to delete: ");
        string? identificationNumberInput = Console.ReadLine();
        var Customer = Customers.FirstOrDefault(x => x.GetIdentificationNumber() == identificationNumberInput);

        if (Customer != null)
        {
            Customers.Remove(Customer);
            Console.WriteLine(@"
The customer has been deleted successfully!");
        }
        else
        {
            Console.WriteLine(@$"The customer with the document number {identificationNumberInput} does not exist, please verify the information and try again.");
        }
    }

    public void UpdateLicenseCategory()
    {
        
    }

    public void AddVehicle(Vehicle vehicle)
    {
        Vehicles.Add(vehicle);
    }
}
