using Models_ReadMe_Exercise_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models_ReadMe_Exercise_1
{
    public class Dog : Animal, IAnimal
    {
        public string Gender { get; set; }
        public Dog(string name, string color, string favouriteFood, string gender) :
            base(name, color, favouriteFood)
        {
            Gender = gender;
        }

        public override string PrintAnimal()
        {
            return base.PrintAnimal() + $"Gender {Gender}";
        }

        public override string Bark()
        {
            return base.Bark();
        }
    }
}