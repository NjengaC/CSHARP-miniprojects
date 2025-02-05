using System;

namespace MyFirstApp
{
    public class Cat : Animal, IMovable
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says Meaw!");
        }

        public void Scratch()
        {
            Console.WriteLine($"{Name} is scratching the pole!");
        }
        public void Move()
        {
            Console.WriteLine($"{Name} is walking gracefully");
        }
    }
}
