using Models_Readme.Exercise_1;

namespace Modes_Exercise_1.StaticExtensions
{
    public static class CircleExtensions
    {
        public static void PrintInfo(this Circle circle)
        {
            Console.WriteLine("Circle {0} has radius {1}, area {2}, and perimeter {3}",
            circle.Id, circle.Radius, circle.GetArea(), circle.GetPerimeter());
        }

        public static void PrintInfo(this Rectangle rectangle)
        {
            Console.WriteLine("Rectangle {0} has sides {1} and {2}, area {3}, and perimeter {4}",
            rectangle.Id, rectangle.SideA, rectangle.SideB, rectangle.GetArea(), rectangle.GetPerimeter());
        }
    }
}
