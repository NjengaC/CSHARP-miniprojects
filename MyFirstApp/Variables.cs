using System;
namespace MyFirstApp
{
    public class VariablesDemo
    {
        public void ShowVariables()
        {
            int age;
            string name;
            bool isMale;
            double height;

            age = 18;
            name = "Unknown";
            isMale = true;
            height = 5.85;

            Console.Write("Enter Name: ");
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No input fed!");
                return;
            }
            name = input;

            Console.WriteLine($"Age for user {name} is {age} years old and height is {height} feets");
            Console.WriteLine($"User is Male? {isMale}");
        }

        public void CheckOdd()
        {
            Console.Write("Enter Number: ");
            string? input = Console.ReadLine();
            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No input fed!");
                return;
            }

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            if (number % 2 != 0)
                Console.WriteLine($"{number} is odd.");
            else
                Console.WriteLine($"{number} is even.");
        }

        public void LoopFun()
        {
            int results = 0;

            do
            {
                Console.Write("Enter first Number: ");
                string? inputOne = Console.ReadLine();
                Console.Write("Enter second Number: ");
                string? inputTwo = Console.ReadLine();
                if(string.IsNullOrEmpty(inputOne) || string.IsNullOrEmpty(inputTwo))
                {
                    Console.Write("Input error!");
                    return;
                }
                if (!int.TryParse(inputOne, out int numberOne) || !int.TryParse(inputTwo, out int numberTwo))
                {
                    Console.WriteLine("Invalid number.");
                    return;
                }
                results = numberTwo + numberOne;
                if (results <= 100)
                    Console.WriteLine($"{numberOne} plus {numberTwo} is {results} and is less than 100, lets do this again!");
                else
                    Console.WriteLine($"{results} is greater than 100, We are done!");
            }
            while (results < 100);
        }

        public void SwitchFun()
        {
            Console.Write("Enter a number between 1-7 to choose days of the week: ");
            string? day = Console.ReadLine();
            if (string.IsNullOrEmpty(day))
            {
                Console.Write("You did not select anything!");
                return;
            }
            switch (day)
            {
                case "1":
                    Console.WriteLine("You selected Monday");
                    break;
                case "2":
                    Console.WriteLine("You selected Tuesday");
                    break;
                case "3":
                    Console.WriteLine("You selected Wednesday");
                    break;
                case "4":
                    Console.WriteLine("You selected Thursday");
                    break;
                case "5":
                    Console.WriteLine("You selected Friday");
                    break;
                case "6":
                    Console.WriteLine("You selected Saturday");
                    break;
                case "7":
                    Console.WriteLine("You selected Sunday");
                    break;
                default:
                    Console.WriteLine("Another day from the alien world");
                    break;
            }
        }

    }
}
