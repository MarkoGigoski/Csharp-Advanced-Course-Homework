namespace Models_Readme.Exercise_1
{
    public class Shape
    {
        public int Id { get; set; }
        public Shape(int id)
        {
            Id = id;
        }
        
        public virtual double GetArea()
        {
            return 0;
        }
        public virtual double GetPerimeter()
        {
            return 0;
        }

    }
}