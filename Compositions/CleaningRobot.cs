using System;

namespace Compositions
{
    public class CleaningRobot: Robot
    {
        public int Distance { get; private set; }
        public CleaningRobot(string name, int distance) : base(name)
        {
            Distance = distance;
        }

        public void CleanRoom()
        {
            Console.WriteLine($"I am cleaning a room, {Distance} meters covered so far");
            Distance += 30;
            DischargeRobot();
        }
    }
}
