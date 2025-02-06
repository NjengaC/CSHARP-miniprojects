using System;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Alice", 85.5));
            students.Add(new Student("Peter", 95.0));
            students.Add(new Student("Jade", 75.5));
            students.Add(new Student("Clement", 80.0));
            
            Console.WriteLine("--- Displaying Students ---");

            foreach (Student student in students)
            {
                student.PrintInfo();
            }

            Console.WriteLine($"Students average grade is {CalculateAverage(students)}");


            Console.WriteLine("\n--- Using Dictionary<key<T>, value<T>> ---");
            Dictionary<string, Student> studentsMap = new Dictionary<string, Student>();

            studentsMap.Add("Alice", new Student("Alice", 85.5));
            studentsMap.Add("Bob", new Student("Bob", 92.5));

            if (studentsMap.TryGetValue("Alice", out Student alice))
            {
                alice.PrintInfo();
            }

            // Use Printer<T>
            Console.WriteLine("\n--- Using Printer<T> ---");
            
            Printer<Student> studentPrinter = new Printer<Student>();
            studentPrinter.PrintAll(students);
        }

        static double CalculateAverage(List<Student> students)
        {
            double total = 0;

            foreach (Student s in students)
            {
                total += s.Grade;
            }
            return total / students.Count;
        }

    }
}
