using Project_ZLAGODA.ViewModels;

namespace Project_ZLAGODA.Backend.Models
{
    internal class EmployeeModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Username { get; set; }
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
