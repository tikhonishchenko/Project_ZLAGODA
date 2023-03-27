using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ZLAGODA.Backend.Models
{
    internal class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public DateTime DateOfBirth{ get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }

        public EmployeeModel(int id, string name, string surname, string patronymic, string role, string phone, decimal salary, DateTime dateOfEmployment, DateTime dateOfBirth, string city, string street, string zip)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Role = role;
            Phone = phone;
            Salary = salary;
            DateOfEmployment = dateOfEmployment;
            DateOfBirth = dateOfBirth;
            City = city;
            Street = street;
            Zip = zip;
        }

        public EmployeeModel()
        {
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Surname} {Patronymic} {Role} {Phone} {Salary} {DateOfEmployment} {DateOfBirth} {City} {Street} {Zip}";
        }



    }
}
