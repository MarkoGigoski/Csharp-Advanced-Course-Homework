namespace Modes_Exercise_1
{
    public class Dog : Pet
    {
        public string FavoriteFood { get; set; }
        public Dog(string name, string type, int age, string favoriteFood)
            : base(name, type, age)
        {
            FavoriteFood = favoriteFood;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} the {Type} age of {Age} loves to eat [{FavoriteFood}]");
        }
    }
}
