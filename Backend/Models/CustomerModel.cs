using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZLAGODA.Backend.Models
{
    internal class CustomerModel
    {
        public string CardNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public int Percent { get; set; }

        public CustomerModel(string cardNumber, string name, string lastName, string patronymic, string phoneNumber, string street, string city, string zipCode, int percent)
        {
            CardNumber = cardNumber;
            Name = name;
            LastName = lastName;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            Street = street;
            City = city;
            ZipCode = zipCode;
            Percent = percent;
        }

        public CustomerModel()
        {
        }

        public override string ToString()
        {
            return $"{CardNumber} {Name} {LastName} {Patronymic} {PhoneNumber} {Street} {City} {ZipCode} {Percent}";
        }
    }
}
