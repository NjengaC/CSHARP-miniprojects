using System;
namespace GameEngine
{
	internal class Program
	{
		public static void Main()
		{
			// 1. Create the game engine (the publisher)
			GameEngine engine = new GameEngine();

			// 2. Add some enemies and treasures
			engine.AddEnemy(new Enemy("Goblin", 30));
			engine.AddEnemy(new Enemy("Orc", 50));
			engine.AddTreasure(new Treasure("Golden Necklace", 100));
			engine.AddTreasure(new Treasure("Silver Coin", 10));

			// 3. Create the subscribers
			Player player = new Player("Hero");
			Logger logger = new Logger();

			// 4. Subscribe their methods to the events
			engine.OnEnemySpotted += player.OnEnemySpottedHandler;
			engine.OnEnemySpotted += logger.OnEnemySpotted;

			engine.OnTreasureFound += player.OnTreasureFoundHandler;
			engine.OnTreasureFound += logger.OnTreasureFound;

			// 5. Simulate multiple scans
			for(int i = 0; i < 5; i++)
			{
				engine.ScanEnvironment();
				System.Threading.Thread.Sleep(2000); // Just to see the outputs clearly
			}

			Console.WriteLine("\nPress any key to quit...");
			Console.ReadKey();
		}
	}
}
