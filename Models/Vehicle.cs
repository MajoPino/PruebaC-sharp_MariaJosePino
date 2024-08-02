using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_MariaJosePino.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string? Plate { get; set; }
        public string? Type { get; set; }
        public string? SerialNumber { get; set; }
        public byte PeopleCapacity { get; set; }
        public Driver Owner { get; set; }

        public Vehicle(int id, string plate, string type, string serialNumber, byte peopleCapacity, Driver owner)
        {
            Id = id;
            Plate = plate;
            Type = type;
            SerialNumber = serialNumber;
            PeopleCapacity = peopleCapacity;
            Owner = owner;
        }

        public void DeleteVehicle(int id)
        {
            
        }
    }
}