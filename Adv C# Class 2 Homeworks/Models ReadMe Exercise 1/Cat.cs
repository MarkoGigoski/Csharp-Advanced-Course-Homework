using Models_ReadMe_Exercise_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models_ReadMe_Exercise_1
{
    public class Cat: Animal, ICat
    {
        public string Gender { get; set; }
        public Cat(string name, string color, string favouriteFood, string gender) :
            base(name, color, favouriteFood)
        {
            Gender = gender;
        }

        public override string PrintAnimal()
        {
            return base.PrintAnimal() + $"Gender {Gender}";
        }

        public override string Eat()
        {
            return base.Eat();
        }
    }
}
