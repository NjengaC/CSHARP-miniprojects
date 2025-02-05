using System;

namespace Compositions
{
    public class Robot
    {
        public string Name{ get; private set; }
        private Battery _battery;

        public void PerformTask()
        {
            _battery.Discharge();
            Console.WriteLine("I am calculating 132 * 22344...");
            Console.WriteLine("132 * 22344 is " + 132 * 22344 + "!");
        }
        public void ChargeRobot()
        {
            _battery.Charge();
        }
        public void DischargeRobot()
        {
            _battery.Discharge();
        }
        public void SayName()
        {
            Console.WriteLine($"My name is {Name}, I am at your service");
        }
        public Robot(string name)
        {
            Name = name;
            _battery = new Battery(75);
            SayName();
        }
    }

    public class Battery
    {
        public int Percentage;
        public bool isCharging = false;
        public void ChargeStatus()
        {
            string status = (isCharging == true)
                ? $"Battery is charging! {Percentage}%"
                : $"Battery is disharging! {Percentage}%";
            Console.WriteLine(status);
        }
        public void Charge()
        {
            isCharging = true;
            ChargeStatus();
            if (Percentage < 90)
                Percentage += 10;
            else if (Percentage > 90 && Percentage < 100)
                Percentage = 100;
            else
                Console.WriteLine("Battery is fully charged");
        }
        public void Discharge()
        {
            isCharging = false;
            if (Percentage > 10)
                Percentage -= 10;
            else
            {
                Console.WriteLine($"Battery is low {Percentage}%");
                throw new ArithmeticException("Please Charge Me!");
            }
            ChargeStatus();
        }
        public Battery(int percentage)
        {
            Percentage = percentage;
        }
    }
}
