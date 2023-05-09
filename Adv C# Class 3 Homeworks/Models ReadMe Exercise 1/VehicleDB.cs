namespace Models_ReadMe_Exercise_1
{
    public static class VehicleDB
    {
        public static List<Vehicle> _vehicles { get; } = new List<Vehicle>()
        {
            new Car() { Id = 1, Type = "Sedan", YearOfProduction = 2019, BatchNumber = 123, FuelTank = 50, ProductionCountries = new string[] { "USA", "Canada" } },
            new Bike() { Id = 2, Type = "Mountain Bike", YearOfProduction = 2020, BatchNumber = 456, Color = "Red" },
            new Vehicle() { Id = 3, Type = "Truck", YearOfProduction = 2021, BatchNumber = 789 }
        };
    }
}
