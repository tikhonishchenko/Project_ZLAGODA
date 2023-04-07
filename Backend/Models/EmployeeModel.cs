using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
        public byte[] PasswordHash { get; set; }
        public string Username { get; set; }
        public byte[] Salt { get; set; }
        

        public EmployeeModel(int id, string name, string surname, string patronymic, string role, string phone, decimal salary, DateTime dateOfEmployment, DateTime dateOfBirth, string city, string street, string zip, string password, string username)
        {
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
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
            PasswordHash = passwordHash;
            Username = username;
            Salt = passwordSalt;

        }

        public EmployeeModel()
        {
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }
        public override string ToString()
        {
            return $"{Id} {Name} {Surname} {Patronymic} {Role} {Phone} {Salary} {DateOfEmployment} {DateOfBirth} {City} {Street} {Zip}";
        }



    }
}
