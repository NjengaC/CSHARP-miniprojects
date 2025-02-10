using System;
namespace GameEngine
{
    public class Enemy : Character
    {
        public Enemy(string name, int health) : base(name, health) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} growls menacingly!");
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacks ferociously!");
        }
    }
}
