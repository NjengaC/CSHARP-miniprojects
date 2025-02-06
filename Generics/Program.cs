using System;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
			students.Add(new Student("Bob", 92, 19));
			students.Add(new Student("Charlie", 78.0, 22));
			students.Add(new Student("Daisy", 64.5, 19));
			students.Add(new Student("Eve", 95, 21));
            students.Add(new Student("Alice", 85.5, 23));
            students.Add(new Student("Peter", 95.0, 34));
            students.Add(new Student("Jade", 75.5, 17));
            students.Add(new Student("Clement", 80.0, 23));
            
            Console.WriteLine("--- Displaying Students ---");

            foreach (Student student in students)
            {
                student.PrintInfo();
            }

            Console.WriteLine($"Students average grade is {CalculateAverage(students)}");


            Console.WriteLine("\n--- Using Dictionary<key<T>, value<T>> ---");
            Dictionary<string, Student> studentsMap = new Dictionary<string, Student>();

            studentsMap.Add("Alice", new Student("Alice", 85.5, 23));
            studentsMap.Add("Bob", new Student("Bob", 92.5, 19));

            if (studentsMap.TryGetValue("Alice", out Student alice))
            {
                alice.PrintInfo();
            }

            // Use Printer<T>
            Console.WriteLine("\n--- Using Printer<T> ---");
            
            Printer<Student> studentPrinter = new Printer<Student>();
            studentPrinter.PrintAll(students);


			var highScorers = from s in students
				where s.Grade > 80
				select s;

			var highScorersMethod = students
				.Where(s => s.Grade > 80);

			Console.WriteLine("--- Students with Grade > 80 ---Sorted using Query syntax");
			foreach(var s in highScorers)
			{
				Console.WriteLine(s);
			}


            var sortedStudents = students.OrderByDescending(s => s.Grade).ThenBy(s => s.Name);

            Console.WriteLine("\n Display students sorted by(Grade desc, Name asc)---\n");
            foreach (var s in sortedStudents)
            {
                Console.WriteLine(s);
            }

            var namesOnly = students.Select(s => s.Name);

			Console.WriteLine("\n--- Student Names Only ---");
			foreach (var name in namesOnly)
			{
				Console.WriteLine(name);
			}

            var gradeAndAge = students
                .Select(s => new
                        {
                        StudentName = s.Name,
                        StudentAge = s.Age,
                        StudentGrade = s.Grade
                        });

            Console.WriteLine("\n--- Anonymous Type Example ---");
            foreach (var info in gradeAndAge)
            {
                Console.WriteLine($"{info.StudentName}, Age: {info.StudentAge}, Grade: {info.StudentGrade}");
            }
            var groupedByAge = from s in students
                group s by s.Age into ageGroup
                select ageGroup;

            Console.WriteLine("\n--- Group By Age ---");
            foreach (var group in groupedByAge)
            {
                Console.WriteLine($"Age: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine("  " + student);
                }
            }

            var averageGrade = students.Average(s => s.Grade);
            var maxGrade = students.Max(s => s.Grade);

            Console.WriteLine($"\nAverage Grade = {averageGrade}");
            Console.WriteLine($"Max Grade = {maxGrade}");

            Console.WriteLine("\n--- First 3 students ---");

            var fewStudents = students.Take(3);

            foreach (Student s in fewStudents)
            {
                Console.WriteLine(s);
            }
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
