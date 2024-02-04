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
    internal interface IAnimal
    {
        string Name { get; set; }
        string Colour { get; set; }
        double Height { get; set; }
        int Age { get; set; }

        abstract void Eat();
        string Cry();
    }
}
