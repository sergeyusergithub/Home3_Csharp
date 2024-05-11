using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home3_Csharp
{
    internal class Journal
    {
        public Journal(string name, int year,
        string description, string phone, string email)
        {
            Name = name;
            Year = year;
            Description = description;
            PhoneNumber = phone;
            Email = email;
        }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public void Print()
        {
            Console.WriteLine($"Название журнала: {Name}\nГод основания: {Year}\n" +
            $"Описание журнала: {Description}\nНомер телефона: {PhoneNumber}" +
            $"\nАдрес электронной почты: {Email}");
        }
    }
}
