using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_MariaJosePino.Models;

    public class Customer : User
    {
        public string? MembershipLevel { get; set; }
        public string? PreferredPaymentMethod { get; set; }

        public Customer(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string address, string membershipLevel, string preferredPaymentMethod) : base(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address)
        {
            MembershipLevel = membershipLevel;
            PreferredPaymentMethod = preferredPaymentMethod;
        }

        public void UpdateMembershipLevel()
        {
            Console.Write(@$"Please, enter the new membership level: ");
            MembershipLevel = Console.ReadLine();
            Console.WriteLine(@$"
Membership level successfully updated!");
        }
    }
