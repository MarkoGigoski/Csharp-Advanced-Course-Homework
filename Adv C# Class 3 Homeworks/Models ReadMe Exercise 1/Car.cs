namespace Models_ReadMe_Exercise_1
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public string[] ProductionCountries { get; set; }

        public new void PrintVehicle()
        {
            Console.WriteLine($"Type: {Type}, Countries produced in: {string.Join(", ", ProductionCountries)}");
        }

    }
}
