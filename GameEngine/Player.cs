using System;
namespace GameEngine
{
	public class Player
	{
		public string Name { get; set; }
		public int Gold { get; private set; }

		public Player(string name)
		{
			Name = name;
			Gold = 0;
		}

		// Event handlers must match the delegates
		public void OnEnemySpottedHandler(Enemy enemy)
		{
			Console.WriteLine($"{Name} sees {enemy.Name}. Prepared to fight or flee...");
			enemy.MakeSound(); // Just to show it in action
		}

		public void OnTreasureFoundHandler(Treasure treasure)
		{
			Console.WriteLine($"{Name} picks up the {treasure}");
			Gold += treasure.Value;
			Console.WriteLine($"{Name} now has {Gold} gold.");
		}
	}
}
