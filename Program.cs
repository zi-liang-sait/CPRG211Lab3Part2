//CPRG 211 F Lab 3 - Interfaces and Abstract classes
//Michael (Zi) Liang 000921925
//Feb 4, 2024

// See https://aka.ms/new-console-template for more information
using CPRG211Lab3Part2;

internal class Program
{
    private static void Main(string[] args)
    {
        //Error checking on inputs is omitted.
        Console.WriteLine("Please enter a dog's name:");
        string dogName = Console.ReadLine();
        Dog dog1 = new Dog();
        dog1.Name = dogName;
        Console.WriteLine("Please enter the dog's colour:");
        dog1.Colour = Console.ReadLine();
        Console.WriteLine("Please enter the dog's age:");
        dog1.Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the dog's height in feet:");
        dog1.Height = double.Parse(Console.ReadLine());
        Console.WriteLine($"{dog1.Name} is a {dog1.Colour}, {dog1.Age} year old, {dog1.Height} foot tall dog.");
        dog1.Eat();
        dog1.Cry();

        //Error checking on inputs is omitted.
        Console.WriteLine("Please enter a cat's name:");
        string catName = Console.ReadLine();
        Cat cat1 = new Cat();
        cat1.Name = catName;
        Console.WriteLine("Please enter the cat's colour:");
        cat1.Colour = Console.ReadLine();
        Console.WriteLine("Please enter the cat's age:");
        cat1.Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the cat's height in feet:");
        cat1.Height = double.Parse(Console.ReadLine());
        Console.WriteLine($"{cat1.Name} is a {cat1.Colour}, {cat1.Age} year old, {cat1.Height} foot tall cat.");
        cat1.Eat();
        cat1.Cry();

        List<IAnimal> animals = new List<IAnimal>();
        animals.Add(dog1);
        animals.Add(cat1);
        animals.Add(new Cat("Bunny", "white", 1.3, 3));
        animals.Add(new Dog("Monty", "maroon", 2.2, 5));
        animals.Add(new Dog("Spencer", "black", 1.8, 10));

        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Name);
        }
    }
}