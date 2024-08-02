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

/* administrator.ShowDriversInfo(); */

administrator.ShowCustomersInfo();