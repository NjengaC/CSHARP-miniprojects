using System;
using System.Collections.Generic;
namespace GameEngine
{
	public class GameEngine
	{
		// Delegate-based Events
		public event EnemySpottedHandler OnEnemySpotted;
		public event TreasureFoundHandler OnTreasureFound;

		// Composition: The engine "has" some enemies and treasures
		private List<Enemy> _enemies;
		private List<Treasure> _treasures;

		public GameEngine()
		{
			_enemies = new List<Enemy>();
			_treasures = new List<Treasure>();
		}

		public void AddEnemy(Enemy enemy)
		{
			_enemies.Add(enemy);
		}

		public void AddTreasure(Treasure treasure)
		{
			_treasures.Add(treasure);
		}

		// Simulate scanning the environment (like a game tick)
		public void ScanEnvironment()
		{
			// For simplicity, pick a random event to raise
			Random rand = new Random();
			int choice = rand.Next(0, 2); // 0 or 1

			if (choice == 0 && _enemies.Count > 0)
			{
				// Spot a random enemy
				Enemy randomEnemy = _enemies[rand.Next(_enemies.Count)];
				Console.WriteLine("GameEngine: An enemy has been spotted!");
				OnEnemySpotted?.Invoke(randomEnemy);
			}
			else if (choice == 1 && _treasures.Count > 0)
			{
				// Find a random treasure
				Treasure randomTreasure = _treasures[rand.Next(_treasures.Count)];
				Console.WriteLine("GameEngine: A treasure has been found!");
				OnTreasureFound?.Invoke(randomTreasure);
			}
			else
			{
				Console.WriteLine("GameEngine: Nothing interesting this time...");
			}
		}
	}
}
