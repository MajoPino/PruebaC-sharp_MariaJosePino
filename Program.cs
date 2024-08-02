using PruebaC_sharp_MariaJosePino.Models;

var administrator = new Administrator();

administrator.AddDriver(new Driver("Juan", "Lòpez", "cc", "143536469", new DateOnly(1997,08,30), "juanlo@gmail.com", "320438536", "Cra #33 2343", "12337844", "A2", 8));
administrator.AddDriver(new Driver("Sara", "Vargas", "cc", "144537461", new DateOnly(2001,11,03), "sariivar12@gmail.com", "325499536", "Cra #39 2883", "11338844", "B2", 9));
administrator.AddDriver(new Driver("Carlos", "Tavorda", "ti", "15273647", new DateOnly(2007,02,28), "carlosgamer007@gmail.com", "385439531", "Cra #28 6842", "128337494", "A2", 1));
administrator.AddDriver(new Driver("Alexander", "Beltràn", "cc", "98358645", new DateOnly(1970,10,12), "alexbeltran@gmail.com", "318838535", "Cra #82 9344", "19398831", "A2", 12));

administrator.AddCustomer(new Customer("Luis", "Dìaz", "cc", "16573434", new DateOnly(2003,09,04), "luismi@gmail.com", "3592263947", "Cra #91 4022", "UltraPlus", "Paypal"));
administrator.AddCustomer(new Customer("Milton", "Rìos", "cc", "16377534", new DateOnly(1993,12,22), "miltonrios@gmail.com", "3192283140", "Cra #12 1082", "Normal", "Tarjeta de Crèdito"));
administrator.AddCustomer(new Customer("Carolina", "Rubio", "cc", "93472713", new DateOnly(1974,12,25), "carorubio@gmail.com", "3592935748", "Cra #82 7024", "Plus", "Paypal"));
administrator.AddCustomer(new Customer("Sergio", "Vargas", "cc", "16573434", new DateOnly(1987,04,30), "sergio22@gmail.com", "3338463639", "Cra #02 4932", "UltraPlus", "Tarjeta de Crèdito"));

void GoToMenu()
{
    Console.WriteLine(@"
Please, press any key to return to the menu.");
    Console.ReadKey();
    Main();
}

void ShowDriversInfo()
{
    administrator.ShowDriversInfo();
}

void ShowCustomersInfo()
{
    administrator.ShowCustomersInfo();
}

void AddDriver()
{
    Console.WriteLine(@$"Please, enter the new Driver's name: ");
    string? name = Console.ReadLine();
    Console.WriteLine(@$"Please, enter the new Driver's last name: ");
    string? lastName = Console.ReadLine();
    Console.WriteLine(@$"Please, enter the new Driver's document type: ");
    string? typeDocument = Console.ReadLine();
    Console.WriteLine(@$"Please, enter the new Driver's document number: ");
    string? identificationNumber = Console.ReadLine();
    Console.WriteLine(@$"Please, enter the new Driver's birth date: ");
    DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
    Console.WriteLine(@"Please, enter the new Driver's email: ");
    string? email = Console.ReadLine();
    Console.WriteLine(@$"Please, enter the new Driver's phone number: ");
    string? phoneNumber = Console.ReadLine();
    Console.WriteLine(@$"Please, enter the new Driver's address: ");
    string? address = Console.ReadLine();
    Console.WriteLine(@$"Please, enter the new Driver's license number: ");
    string? licenseNumber = Console.ReadLine();
    Console.WriteLine(@$"Please, enter the new Driver's license category: ");
    string? licenseCategory = Console.ReadLine();
    Console.WriteLine(@$"Please, enter the new Driver's number of years of driving experience: ");
    int drivingExperience = Convert.ToInt32(Console.ReadLine());

    administrator.AddDriver(new Driver(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address, licenseNumber, licenseCategory, drivingExperience));
    Console.WriteLine(@"
Driver added successfully!");
    GoToMenu();
}

void AddCustomer()
{
    Console.WriteLine(@$"Please, enter the new Customer's name: ");
    string? name = Console.ReadLine();
    Console.WriteLine(@$"Please, enter the new Customer's last name: ");
    string? lastName = Console.ReadLine();
    Console.WriteLine(@$"Please, enter the new Customer's document type: ");
    string? typeDocument = Console.ReadLine();
    Console.WriteLine(@$"Please, enter the new Customer's document number: ");
    string? identificationNumber = Console.ReadLine();
    Console.WriteLine(@$"Please, enter the new Customer's birth date: ");
    DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
    Console.WriteLine(@"Please, enter the new Customer's email: ");
    string? email = Console.ReadLine();
    Console.WriteLine(@$"Please, enter the new Customer's phone number: ");
    string? phoneNumber = Console.ReadLine();
    Console.WriteLine(@$"Please, enter the new Customer's address: ");
    string? address = Console.ReadLine();
    Console.WriteLine(@$"Please, enter the new Customer's membership level: ");
    string? membershipLevel = Console.ReadLine();
    Console.WriteLine(@$"Please, enter the new Customer's preferred payment method: ");
    string? preferredPaymentMethod = Console.ReadLine();

    administrator.AddCustomer(new Customer(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address, membershipLevel, preferredPaymentMethod));
    Console.WriteLine(@"
Customer added successfully!");
    GoToMenu();
}


void Main()
{
    Console.Clear();
    Console.WriteLine(@$"
Welcome to </TransRiwi>
1.Add a new Driver
2.Add a new Customer
3.List all the Drivers
4:List all the Customers
0.Exit");
    Console.Write("Please, choose one of the options from above: ");
    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
        Console.Clear();
        AddDriver();
        break;

        case 2:
        Console.Clear();
        AddCustomer();
        break;

        case 3:
        Console.Clear();
        ShowDriversInfo();
        GoToMenu();
        break;

        case 4:
        Console.Clear();
        ShowCustomersInfo();
        GoToMenu();
        break;

        case 0:
        Console.Clear();
        Console.WriteLine("Thanks for using the program!");
        Environment.Exit(0);
        break;


        default:
        Main();
        break;
    }
}

Main();