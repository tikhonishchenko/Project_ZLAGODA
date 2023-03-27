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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public int Discount { get; set; }

        public CustomerModel(string cardNumber, string firstName, string lastName, string patronymic, string phoneNumber, string address, string city, string zipCode, int discount)
        {
            CardNumber = cardNumber;
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            Address = address;
            City = city;
            ZipCode = zipCode;
            Discount = discount;
        }

        public CustomerModel()
        {
        }

        public override string ToString()
        {
            return $"{CardNumber} {FirstName} {LastName} {Patronymic} {PhoneNumber} {Address} {City} {ZipCode} {Discount}";
        }
    }
}
