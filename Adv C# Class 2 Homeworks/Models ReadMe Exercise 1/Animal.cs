using Models_ReadMe_Exercise_1.Interfaces;
using System;

namespace Models_ReadMe_Exercise_1
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string FavouriteFood { get; set; }
        public Animal(string name, string color, string favouriteFood)
        {
            Name = name;
            Color = color;
            FavouriteFood = favouriteFood;
        }

        public virtual string PrintAnimal()
        {
            return $" Name: {Name}, Color: {Color}, FavouriteFood: {FavouriteFood}";
        }

        public virtual string Bark()
        {
            return "Bark Bark";
        }

        public virtual string Eat()
        {
            return "Eat Eat";
        }


    }
}
