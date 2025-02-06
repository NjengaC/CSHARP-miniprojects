using System;

namespace Generics
{
    public class Student
    {
        public string Name { get; private set; }
        public double Grade { get; private set; }

        public Student(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student {Name} has {Grade} points");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Grade: {Grade}";
        }
    }
}
