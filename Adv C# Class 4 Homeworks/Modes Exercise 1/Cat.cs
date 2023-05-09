using Modes_Exercise_1.Enums;

namespace Modes_Exercise_1
{
    public class Cat : Pet
    {
        public LifesEnum LifesLeft { get; set; }
        public LazyEnum Lazy { get; set; }
        public Cat(string name, string type, int age, LifesEnum lifesLeft, LazyEnum lazy)
            : base(name, type, age)
        {
            LifesLeft = lifesLeft;
            Lazy = lazy;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} the {Type} age of {Age} has {LifesLeft} lifes left and is: {Lazy}");
        }
    }
}
