namespace Modes_Exercise_1
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public Fish(string name, string type, int age, string color, string size)
            : base(name, type, age)
        {
            Color = color;
            Size = size;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is {Type} and has {Age} years. His color is {Color} and is regarded as a [{Size}]");
        }
    }
}
