using Models_Readme.Exercise_1;
using Models_Readme.Exercise_1.DBgeneric;
using Modes_Exercise_1.StaticExtensions;

namespace Adv_C__Class_4_Readme.Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class 4 Readme.Exercise 1
            Console.WriteLine("Class 4 Readme.Exercise 1");
            /*
            ▸ Create a class Shape that has Id and methods GetArea and GetPerimeter
            ▸ Create a class Circle, with property radius that inherits from Shape.
            ▸ Create a class Rectangle, with properties sideA and sideB that inherits from Shape.
            ▸ Create a generic Db that holds a list of generic objects, that have a type that inherits from Shape.
            ▸ Create methods in the generic db that print the areas and perimeters of all shapes in the list.
            ▸ Create generic db for both types and call the methods of the db.
            ▸ Add extension methods for Circle and Rectangle, that print info for these types.
            */

            DB<Circle> circleDb = new DB<Circle>();
            Circle circle1 = new Circle(1, 10);
            circleDb.Add(circle1);
            Circle circle2 = new Circle(2, 25);
            circleDb.Add(circle2);
            circleDb.PrintAreas();
            circleDb.PrintPerimetars();
            circle1.PrintInfo();
            CircleExtensions.PrintInfo(circle2);


            DB<Rectangle> rectangleDb = new DB<Rectangle>();
            Rectangle rectangle1 = new Rectangle(3, 10, 5);
            rectangleDb.Add(rectangle1);
            Rectangle rectangle2 = new Rectangle(4, 20, 104);
            rectangleDb.Add(rectangle2);
            rectangleDb.PrintAreas();
            rectangleDb.PrintPerimetars();
            rectangle2.PrintInfo();
            CircleExtensions.PrintInfo(rectangle1);
           
        }
    }
}