using System.Net.Http.Headers;

namespace Models_Exercise_1
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Color { get; set; }

        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public string Bark()
        {
            return $"{Name} Bark Bark";
        }

        public static bool Validate(Dog dog)
        {
            if (dog == null) return false;

            if(dog.Id <= 0 || dog.Name.Length <= 2)
            {
                return false;
            }

            return true;
        }
    }
}