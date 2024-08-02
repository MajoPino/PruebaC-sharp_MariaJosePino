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

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }
    }
