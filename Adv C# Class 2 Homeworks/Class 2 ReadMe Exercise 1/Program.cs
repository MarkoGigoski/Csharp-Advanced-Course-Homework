using Models_ReadMe_Exercise_1;

namespace Class_2_ReadMe_Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1 from ReadMe class 2
            Console.WriteLine("Exercise 2 class 2");
            /*
            ● Create interfaces called IAnimal, IDog, ICat
              - IAnimal : Contains method PrintAnimal
              - IDog - Contains method Bark
              - ICat - Contains method Eat that gets parameter food of type string
            ● Create an abstract class Animal (you choose the properties) that implements IAnimal, with abstract method PrintAnimal
            ● Create class Dog that implements IDog and inherits from Animal. Implement PrintAnimal but also Bark.
            ● Create class Cat that implements ICat and inherits from Animal. Implement PrintAnimal but also Eat.
            ● Create several objects and test the method calls
            */

            // Testing objects
            Dog d1 = new Dog("Bugzy", "White/Brown", "BBQ", "Male");
            Dog d2 = new Dog("Charly", "Black", "Cats", "Female");
            Cat c1 = new Cat("Lea", "Yellow/White", "Mice", "Female");
            Cat c2 = new Cat("Ben", "Grey", "Fish", "Male");

            // Calling Methods
            Console.WriteLine(d1.PrintAnimal());
            Console.WriteLine(d2.PrintAnimal());
            Console.WriteLine(c1.PrintAnimal());
            Console.WriteLine(c2.PrintAnimal());

            Console.WriteLine(d1.Bark());
            Console.WriteLine(d2.Bark());
            Console.WriteLine(c1.Eat());
            Console.WriteLine(c2.Eat());

            // From the text i understood that Bark and Eat are aswell methods and not just to add "Bark Bark" to the base.PrintAnimal,
            // I hope i wasnt wrong :)
        }
    }
}