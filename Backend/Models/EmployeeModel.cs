using Project_ZLAGODA.ViewModels;
using System.ComponentModel;

namespace Project_ZLAGODA.Backend.Models
{
    internal class EmployeeModel
    {
        [DisplayName("Id")]
        public string Id { get; set; }
        [DisplayName("Ім'я")]
        public string Name { get; set; }
        [DisplayName("Прізвище")]
        public string Surname { get; set; }
        [DisplayName("По-батькові")]
        public string Patronymic { get; set; }
        [DisplayName("Роль")]
        public string Role { get; set; }
        [DisplayName("Номер телефону")]
        public string Phone { get; set; }
        [DisplayName("Зарплата")]
        public decimal Salary { get; set; }
        [DisplayName("Дата прийняття на роботу")]
        public DateTime DateOfEmployment { get; set; }
        [DisplayName("Дата народження")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Місто")]
        public string City { get; set; }
        [DisplayName("Вулиця")]
        public string Street { get; set; }
        [DisplayName("Індекс")]
        public string Zip { get; set; }
        [Browsable(false)]
        public byte[] PasswordHash { get; set; }
        [Browsable(false)]
        public string Username { get; set; }
        [Browsable(false)]
        public byte[] Salt { get; set; }


        public EmployeeModel(string id, string name, string surname, string patronymic, string role, string phone, decimal salary, DateTime dateOfEmployment, DateTime dateOfBirth, string city, string street, string zip, string password, string username)
        {
            ViewModel.CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
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
        public override string ToString()
        {
            return $"{Id} {Name} {Surname} {Patronymic} {Role} {Phone} {Salary} {DateOfEmployment} {DateOfBirth} {City} {Street} {Zip}";
        }



    }
}
