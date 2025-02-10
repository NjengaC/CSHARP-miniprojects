using System;
namespace GameEngine
{
	public class Logger
	{
		public void OnEnemySpotted(Enemy enemy)
		{
			Console.WriteLine($"[LOG] Enemy spotted: {enemy.Name}, HP: {enemy.Health}");
		}

		public void OnTreasureFound(Treasure treasure)
		{
			Console.WriteLine($"[LOG] Treasure found: {treasure}");
		}
	}
}
