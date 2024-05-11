using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home3_Csharp
{
    internal class Store
    {
        public Store(string name, string address,
        string description, string phone, string email)
        {
            Name = name;
            Address = address;
            Description = description;
            PhoneNumber = phone;
            Email = email;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public void Print()
        {
            Console.WriteLine($"Название магазина: {Name}\nАдресс магазина: {Address}\n" +
            $"Описание магазина: {Description}\nНомер телефона: {PhoneNumber}" +
            $"\nАдрес электронной почты: {Email}");
        }
    }
}
