//CPRG 211 F Lab 3 - Interfaces and Abstract classes
//Michael (Zi) Liang 000921925
//Feb 4, 2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211Lab3Part2
{
    internal class Dog : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        public Dog()
        {
            this.Name = "Max";
            this.Colour = "Brown";
            this.Height = 1.6;
            this.Age = 3;
        }

        public Dog(string name, string colour, double height, int age)
        {
            this.Name = name;
            this.Colour = colour;
            this.Height = height;
            this.Age = age;
        }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }

        public string Cry()
        {
            Console.WriteLine("Woof!");
            return "Woof!";
        }
    }
}
