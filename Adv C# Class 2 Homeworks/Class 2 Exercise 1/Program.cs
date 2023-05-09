using Modesl_Exercise_1;

namespace Class_2_Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Class 2 Exercise 1");
            /*
            ● Create an interfaces called IUser, IStudent, ITeacher
              ▹ IUser : Id, Name, Username, Password, PrintUser() - Prints Id, Name and Username
              ▹ IStudent: Grades, override PrintUser() to show grades
              ▹ ITeacher : Subject, override PrintUser() to show subject
            ● Create an abstract class User and inherits from IUser
            ● Create a class Student that inherits from User and IStudent
            ● Create a class Teacher that inherits from User and ITeacher
            ● Create 2 teacher and 2 student objects and call PrintUser() on all of them
            */

            // Students
            Student s1 = new Student(1, "Marko", "markogigoski", "Passw0rd123!", new List<int> { 10, 9, 8, 8 });
            Student s2 = new Student(2, "Kristina", "kika", "Metamorfoza123!", new List<int> { 10, 9, 10, 9 });

            // Teachers
            Teacher t1 = new Teacher(3, "Risto", "ristopanchevski", "Kilimandzaro456!", "C# Baisic");
            Teacher t2 = new Teacher(4, "Tijana", "tijanatijana", "Sedc432!", "C# Advanced");

            // PrintUser calls
            Console.WriteLine(s1.PrintUser());
            Console.WriteLine(s2.PrintUser());
            Console.WriteLine(t1.PrintUser());
            Console.WriteLine(t2.PrintUser());

            


        }
    }
}