using Models_Exercise_1;
using System.Net.Http.Headers;

namespace Class_3_Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class 3 Exercise 1
            Console.WriteLine("Class 3 Exercise 1");
            /*
            ● Create a class called Dog that has:
              ▹ Id, Name, Color, Bark() - Prints “Bark Bark”
              ▹ A static method Validate() - Checks if dog has all 3 properties,
                if Id is not less than 0 and Name is 2 characters or longer
            ● Create a static class called DogShelter that has:
              ▹ List of Dogs
              ▹ PrintAll() - prints all dogs from List of Dogs
            ● Create 3 Dog objects, call validate on them to see if they are
            okay, add them in the List of Dogs and call PrintAll()
            */

            // Dogs obj
            Dog dog1 = new Dog(1, "Ben", "Black");
            if (Dog.Validate(dog1))
            {
                DogShelter.AddDog(dog1);
            }

            Dog dog2 = new Dog(0, "Lucky", "White");
            if (Dog.Validate(dog2))
            {
                DogShelter.AddDog(dog2);
            }

            Dog dog3 = new Dog(3, "Maw", "Brown");
            if (Dog.Validate(dog3))
            {
                DogShelter.AddDog(dog3);
            }

            DogShelter.PrintAll();

            Console.WriteLine(dog1.Bark());
            Console.WriteLine(dog2.Bark());
            Console.WriteLine(dog3.Bark());

          
            

        }
    }


}