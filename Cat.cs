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
    internal class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        public Cat()
        {
            this.Name = "Atkins";
            this.Colour = "Grey";
            this.Height = 1.3;
            this.Age = 4;
        }

        public Cat (string name, string colour, double height, int age)
        {
            this.Name = name;
            this.Colour = colour;
            this.Height = height;
            this.Age = age;
        }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }

        public string Cry()
        {
            Console.WriteLine("Meow!");
            return "Meow!";
        }
    }
}
