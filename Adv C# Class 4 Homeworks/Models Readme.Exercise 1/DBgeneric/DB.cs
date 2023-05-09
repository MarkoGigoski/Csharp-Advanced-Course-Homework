namespace Models_Readme.Exercise_1.DBgeneric
{
    public class DB<T> where T : Shape
    {
        private List<T> shapes;
        public DB()
        {
            shapes = new List<T>();
        }

        public void Add(T shape)
        {
            shapes.Add(shape);
        }
        public void PrintAreas()
        {
            foreach(T shape in shapes)
            {
                Console.WriteLine("Area: ");
                Console.WriteLine($"Shape :{shape.Id}, has area of: [{shape.GetArea()}]");
            }
        }
        public void PrintPerimetars()
        {
            foreach (T shape in shapes)
            {
                Console.WriteLine("Perimetar: ");
                Console.WriteLine($"Shape :{shape.Id}, has perimetar: [{shape.GetPerimeter()}]");
            }

        }

    }
}
