namespace Modes_Exercise_1
{
    public abstract class Pet
    {
        //Name, Type, Age and abstract PrintInfo()
        public string Name { get; set; }
        public string Type { get; set; } 
        public int Age { get; set; }
        public Pet(string name,string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
        public abstract void PrintInfo();
        


    }

    
}