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
            string? age = Convert.ToString(Driver.ReturnAge());

            Console.WriteLine(@$"
Driver's Name: {name} {lastname}
Identification Document: {typeDocument} {identificationNumber}
Birth Date: {birthDate}
Age: {age} years old
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
            string? age = Convert.ToString(Customer.ReturnAge());

            Console.WriteLine(@$"
Customer's Name: {name} {lastname}
Identification Document: {typeDocument} {identificationNumber}
Birth Date: {birthDate}
Age: {age} years old
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
            string? age = Convert.ToString(driver.ReturnAge());

            Console.WriteLine(@$"
Driver's Name: {name} {lastname}
Identification Document: {typeDocument} {identificationNumber}
Birth Date: {birthDate}
Age: {age} years old
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
            string? age = Convert.ToString(Customer.ReturnAge());

            Console.WriteLine(@$"
Customer's Name: {name} {lastname}
Identification Document: {typeDocument} {identificationNumber}
Birth Date: {birthDate}
Age: {age} years old
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
        Console.Write("Please, enter the document number of the driver you want to update their license category: ");
        string? identificationNumberInput = Console.ReadLine();
        var Driver = Drivers.FirstOrDefault(x => x.GetIdentificationNumber() == identificationNumberInput);

        if (Driver != null)
        {
            Console.Write("Please, enter the new driver's license category: ");
            string? newCategory = Console.ReadLine();

            Driver.UpdateLicenseCategory(newCategory);
            Console.WriteLine(@"
The license category has been updated succesfully!");
        }
        else
        {
            Console.WriteLine(@$"The driver with the document number {identificationNumberInput} does not exist, please verify the information and try again.");
        }
    }

    public void AddExperience()
    {
        Console.Write("Please, enter the document number of the driver you want to update their driving experience: ");
        string? identificationNumberInput = Console.ReadLine();
        var Driver = Drivers.FirstOrDefault(x => x.GetIdentificationNumber() == identificationNumberInput);

        if (Driver != null)
        {
            Console.Write("Please, enter the new driver's driving experience (in years): ");
            int years = Convert.ToInt32(Console.ReadLine());

            Driver.AddExperience(years);
            Console.WriteLine(@"
The driver's driving experience has been updated succesfully!");
        }
        else
        {
            Console.WriteLine(@$"The driver with the document number {identificationNumberInput} does not exist, please verify the information and try again.");
        }
    }

    public void UsersElderThan30()
    {
        List<Driver> newDrivers = Drivers.Where(x => x.ReturnAge() >= 30).ToList();
        List<Customer> newCustomers = Customers.Where(x => x.ReturnAge() >= 30).ToList();

        foreach (var Driver in newDrivers)
        {
            string? name = Convert.ToString(Driver.GetName());
            string? lastname = Convert.ToString(Driver.GetLastName());
            string? typeDocument = Convert.ToString(Driver.GetTypeDocument());
            string? identificationNumber = Convert.ToString(Driver.GetIdentificationNumber());
            string? birthDate = Convert.ToString(Driver.GetBirthDate());
            string? email = Convert.ToString(Driver.GetEmail());
            string? phone = Convert.ToString(Driver.GetPhoneNumber());
            string? address = Convert.ToString(Driver.GetAddress());
            string? age = Convert.ToString(Driver.ReturnAge());

            Console.WriteLine(@$"
Driver's Name: {name} {lastname}
Identification Document: {typeDocument} {identificationNumber}
Birth Date: {birthDate}
Age: {age} years old
Email: {email}
Phone Number: {phone}
Address: {address}
License: {Driver.LicenseCategory} {Driver.LicenseNumber}
Driving Experience: {Driver.DrivingExperience} years
");
        }

        foreach (var Customer in newCustomers)
        {
            string? name = Convert.ToString(Customer.GetName());
            string? lastname = Convert.ToString(Customer.GetLastName());
            string? typeDocument = Convert.ToString(Customer.GetTypeDocument());
            string? identificationNumber = Convert.ToString(Customer.GetIdentificationNumber());
            string? birthDate = Convert.ToString(Customer.GetBirthDate());
            string? email = Convert.ToString(Customer.GetEmail());
            string? phone = Convert.ToString(Customer.GetPhoneNumber());
            string? address = Convert.ToString(Customer.GetAddress());
            string? age = Convert.ToString(Customer.ReturnAge());

            Console.WriteLine(@$"
Customer's Name: {name} {lastname}
Identification Document: {typeDocument} {identificationNumber}
Birth Date: {birthDate}
Age: {age} years old
Email: {email}
Phone Number: {phone}
Address: {address}
Membership Level: {Customer.MembershipLevel}
Preferred Payment Method: {Customer.PreferredPaymentMethod}
");
        }
    }

    public void UpdateMembershipLevel()
    {
        Console.Write("Please, enter the document number of the customer you want to update the membership lever: ");
        string? identificationNumberInput = Console.ReadLine();
        var Customer = Customers.FirstOrDefault(x => x.GetIdentificationNumber() == identificationNumberInput);

        if (Customer != null)
        {
            Customer.UpdateMembershipLevel();
        }
        else
        {
            Console.WriteLine(@$"The customer with the document number {identificationNumberInput} does not exist, please verify the information and try again.");
        }
    }

    public void AddVehicle()
    {
        Console.WriteLine("Please, enter the new Vehicle's Id: ");
        int Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please, enter the new Vehicle's Plate: ");
        string? Plate = Console.ReadLine();
        Console.WriteLine("Please, enter the new Vehicle's Type: ");
        string? Type = Console.ReadLine();
        Console.WriteLine("Please, enter the new Vehicle's Serial Number: ");
        string? SerialNumber = Console.ReadLine();
        Console.WriteLine("Please, enter the new Vehicle's People Capacity: ");
        byte PeopleCapacity = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Please, enter the new Vehicle's Owner's Identification Number: ");
        string? identificationNumberInput = Console.ReadLine();
        Driver driver = Drivers.FirstOrDefault(x => x.GetIdentificationNumber() == identificationNumberInput);
        Vehicles.Add(new Vehicle(Id, Plate, Type, SerialNumber, PeopleCapacity, driver));
    }
}
