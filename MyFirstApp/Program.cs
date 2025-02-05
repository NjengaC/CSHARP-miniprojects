using System;

namespace MyFirstApp
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            Console.WriteLine("...");

            Dog dog = new Dog("Bosko", 5);
            Cat cat = new Cat("Pusi", 3);

            Console.WriteLine($"Dog's name is {dog.Name} and he is {dog.Age} years old");
            dog.Eat();
            dog.MakeSound();
            dog.Move();
            dog.Fetch();

            Console.WriteLine("...\n");

            Console.WriteLine($"Cat's name is {cat.Name} and she is {cat.Age} years old");
            cat.Eat();
            cat.MakeSound();
            cat.Move();
            cat.Scratch();
            Console.WriteLine("Presss any key to quit");
            Console.ReadKey();

        }

                        
    }
}
