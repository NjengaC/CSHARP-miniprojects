using System;

namespace MyFirstApp
{
    public abstract class Animal
    {
        public string Name{ get; private set; }
        public int Age { get; private set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} Is Eating!");
        }

        public abstract void MakeSound();
    }
}
