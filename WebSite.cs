using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home3_Csharp
{
    internal class Website
    {
        public Website(string name, string pathweb, string description, string ipaddress)
        {
            Name = name;
            PathWeb = pathweb;
            Description = description;
            IPaddress = ipaddress;
        }
        public string Name { get; set; }
        public string PathWeb { get; set; }
        public string Description { get; set; }
        public string IPaddress { get; set; }

        public void Print()
        {
            Console.WriteLine($"Название сайта: {Name}\nПолный путь: {PathWeb}\n" +
            $"Описание сайта: {Description}\nIP адрес: {IPaddress}");
        }
    }
}
