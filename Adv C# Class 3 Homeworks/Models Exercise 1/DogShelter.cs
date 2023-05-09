namespace Models_Exercise_1
{
    public static class DogShelter
    {
        public static List<Dog> ListOfDogs = new List<Dog>();

        public static void PrintAll()
        {
            foreach (Dog dog in ListOfDogs)
            {
                Console.WriteLine($"Id: {dog.Id}, Name: {dog.Name}, Color: {dog.Color}");
            }
        }

        public static void AddDog(Dog dog)
        {
            if (Dog.Validate(dog))
            {
                ListOfDogs.Add(dog);
            }
            else
            {
                Console.WriteLine($"Dog with Id: {dog.Id}, Name: {dog.Name}, Color: {dog.Color} is invalid.");
            }
        }
    }
}
