using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZLAGODA.Backend.Models
{
    internal class CustomerModel
    {
        [DisplayName("Номер картки")]
        public string CardNumber { get; set; }
        [DisplayName("Ім'я")]
        public string Name { get; set; }
        [DisplayName("Прізвище")]
        public string LastName { get; set; }
        [DisplayName("По-батькові")]
        public string Patronymic { get; set; }
        [DisplayName("Номер телефону")]
        public string PhoneNumber { get; set; }
        [DisplayName("Вулиця")]
        public string Street { get; set; }
        [DisplayName("Місто")]
        public string City { get; set; }
        [DisplayName("Індекс")]
        public string ZipCode { get; set; }
        [DisplayName("Відсоток")]
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
