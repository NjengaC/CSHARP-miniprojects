using System;

namespace Compositions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a robot instance...");
            Robot robot = new Robot("Sparrow");
            robot.ChargeRobot();
            robot.PerformTask();

            Console.WriteLine("..........................\n");
            Console.WriteLine("Creating a cleaning robot instance...");
            CleaningRobot cleaner = new CleaningRobot("Spakle", 0);
            cleaner.CleanRoom();
            cleaner.CleanRoom();
            cleaner.CleanRoom();
            cleaner.CleanRoom();
            cleaner.ChargeRobot();
        }
    }
}
