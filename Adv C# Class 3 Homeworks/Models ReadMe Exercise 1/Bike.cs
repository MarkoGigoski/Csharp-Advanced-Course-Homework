namespace Models_ReadMe_Exercise_1
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }
        public new void PrintVehicle()
        {
            Console.WriteLine($"Production year: [{YearOfProduction}], Color: [{Color}]");
        }



    }
}
