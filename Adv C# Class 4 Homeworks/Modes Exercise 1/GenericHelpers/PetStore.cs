using System.Collections.Generic;
using System.Xml.Linq;

namespace Modes_Exercise_1.GenericHelpers
{
    public class PetStore<T> where T : Pet
    {
        public List<T> ListOfPets = new List<T>();

        public void AddPet(T pet)
        {
            ListOfPets.Add(pet);
        }

        public void buyPet(string name)
        {
            T petToBuy = ListOfPets.Find(p => p.Name == name);
            if (petToBuy != null)
            {
                ListOfPets.Remove(petToBuy);
                Console.WriteLine($"Successfully bought pet {name}.");
            }
            else
            {
                Console.WriteLine($"No pet with name {name} was found.");
            }
        }

        public void printPets()
        {
            foreach (T pet in ListOfPets)
            {
                pet.PrintInfo();
            }
        }

    }
}
