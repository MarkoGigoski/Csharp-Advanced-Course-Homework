namespace Models_ReadMe_Exercise_1
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }
        public void PrintVehicle()
        {
            Console.WriteLine($" Vehicle Id number: [{Id}] - Type: [{Type}] - Produced: [{YearOfProduction}]");
        }

    }
}
