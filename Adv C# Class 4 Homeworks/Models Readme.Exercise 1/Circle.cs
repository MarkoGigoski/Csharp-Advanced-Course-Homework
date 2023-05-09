namespace Models_Readme.Exercise_1
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(int id,double radius)
            : base(id)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }


    }
}
