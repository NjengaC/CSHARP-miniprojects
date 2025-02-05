using System;

namespace MyFirstApp
{
    public class Dog : Animal, IMovable
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says Whoof!");
        }

        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching a ball");
        }
        public void Move()
        {
            Console.WriteLine($"{Name} is running");
        }
    }
}
