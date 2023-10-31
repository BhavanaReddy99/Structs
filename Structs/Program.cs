using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{

    struct Student
    {
        public string Name;
        public int Age;
        public string Course;
        public double GPA;
    }

    class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        static void doApp()
        {
            Student student;

            Console.Write("Enter student's name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter student's age: ");
            if (int.TryParse(Console.ReadLine(), out student.Age) == false)
            {
                Console.WriteLine("Invalid input for age. Please enter a valid integer.");
                return;
            }

            Console.Write("Enter student's course: ");
            student.Course = Console.ReadLine();

            Console.Write("Enter student's GPA: ");
            if (double.TryParse(Console.ReadLine(), out student.GPA) == false)
            {
                Console.WriteLine("Invalid input for GPA. Please enter a valid number.");
                return;
            }

            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"Course: {student.Course}");
            Console.WriteLine($"GPA: {student.GPA}");
        }
    }

}
