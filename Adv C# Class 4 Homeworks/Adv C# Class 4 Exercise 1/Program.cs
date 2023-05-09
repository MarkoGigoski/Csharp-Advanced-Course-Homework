using Modes_Exercise_1;
using Modes_Exercise_1.GenericHelpers;

namespace Adv_C__Class_4_Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class 4 Exercise 1
            Console.WriteLine("Class 4 Exercise 1");
            /*
            ▸ Create 4 classes: 
              ▹ Pet( abstract ) with Name, Type, Age and abstract PrintInfo()
              ▹ Dog( from Pet ) with FavoriteFood
              ▹ Cat( from Pet ) with Lazy and LivesLeft
              ▹ Fish( from Pet ) with Color, Size
            ▸ Create a PetStore generic class with:
              ▹ Generic list of pets - Dogs, Cats or Fish depending on what is passed as T
              ▹ Generic method printsPets() - Prints Dogs, Cats or Fish depending on what is passed as T 
              ▹ BuyPet() - Method that takes ‘name’ as parameter, find the first pet by that name,
                removes it from the list and gives a success message. If there is no pet by that name, inform the customer
            ▸ Create a Dog, Cat and Fish store with 2 pets each
              ▹ Buy a dog and a cat from the Dog and Cat store
              ▹ Call PrintPets() method on all stores
            */


            // Dog Store
            Console.WriteLine("---------- DOG STORE ----------");
            PetStore<Dog> aDogStore = new PetStore<Dog>();

            Dog dog1 = new Dog("WhiteBoyClark", "Pitbull", 93, "Human Flesh..");
            Dog dog2 = new Dog("BlacBird", "Doberman", 107, "Cats..");

            aDogStore.AddPet(dog1);
            aDogStore.AddPet(dog2);

            aDogStore.buyPet("WhiteBoyClark");
            aDogStore.printPets();


            // Cat Store
            Console.WriteLine("---------- CAT STORE ----------");
            PetStore<Cat> aCatStore = new PetStore<Cat>();

            Cat cat1 = new Cat("Mufasa","Lion", 8,Modes_Exercise_1.Enums.LifesEnum.NoMoreLifesLeft,Modes_Exercise_1.Enums.LazyEnum.NotLazy);
            Cat cat2 = new Cat("Shirkan", "Tiger", 10, Modes_Exercise_1.Enums.LifesEnum.Nine,Modes_Exercise_1.Enums.LazyEnum.Lazy);

            aCatStore.AddPet(cat1);
            aCatStore.AddPet(cat2);

            aCatStore.buyPet("Mufasa");
            aCatStore.printPets();


            // Fish Sore
            Console.WriteLine("---------- FISH STORE ----------");

            PetStore<Fish> aFishStore = new PetStore<Fish>();

            Fish fish1 = new Fish("Nemo", "Ocellaris Clownfish", 2, "Orange - White", "Small Fish");
            Fish fish2 = new Fish(@"Nemo's Dad", "Ocellaris Clownfish", 8, "Orange - White", "Small Fish");

            aFishStore.AddPet(fish1);
            aFishStore.AddPet(fish2);

            aFishStore.buyPet("Nemo");
            aFishStore.printPets();


        }
    }
}