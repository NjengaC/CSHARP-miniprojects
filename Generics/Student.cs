using System;

namespace Generics
{
	public class Student
	{
		public string Name { get; set; }
		public double Grade { get; set; }
		public int Age { get; set; }

		public Student(string name, double grade, int age)
		{
			Name = name;
			Grade = grade;
			Age = age;
		}

		public override string ToString()
		{
			return $"Name: {Name}, Grade: {Grade}, Age: {Age}";
		}

        public void PrintInfo()
        {
            Console.WriteLine($"Student {Name} has {Grade} points");
        }

    }
}
