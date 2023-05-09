using Models_ReadMe_Exercise_1;

namespace Class_3_ReadMe_Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class 3 ReedMe File Exercise 1
            Console.WriteLine("Class 3 ReedMe File Exercise 1");
            /*
            ● Create a class Vehicle with properties Id, Type, YearOfProduction, BatchNumber.
            ● Create two classes Car and Bike that inherit from Vehicle.
              - Car has property FuelTank (int) and Countries in which it is produced and Bike has property Color.
            ● Class Vehicle has method PrintVehicle that prints Id, Type and YearOfProduction.
            ● Class Car also has method PrintVehicle that prints the Type and the Countries in which it is produced.
            ● Class Bike also has method PrintVehicle that Prints the YearOfProduction and the Color.
            ● Create a static class that serves as a DB, that has list of Vehicles.
              - In this list put objects of type Car, Bike and Vehicle.
            ● In the main program call PrintVehicle for each object in the list in the db.
            ● Create a static class called Validator, that contains a method Validate,
              - that receives a Vehicle and validates is Id is not 0, that Type is not empty and YearOfProduction is not 0.
            ● Call Validate from main Program with a couple of objects.
            */

            foreach (Vehicle vehicle in VehicleDB._vehicles)
            {
                vehicle.PrintVehicle();
            }

            Console.WriteLine();

            Vehicle car = new Car() { Id = 4, Type = "Coupe", YearOfProduction = 2022, BatchNumber = 111, FuelTank = 60, ProductionCountries = new string[] { "Germany", "France" } };
            Vehicle bike = new Bike() { Id = 5, Type = "Road Bike", YearOfProduction = 2023, BatchNumber = 222, Color = "Blue" };

            Console.WriteLine($"Car validation result: {Validator.Validate(car)}");
            Console.WriteLine($"Bike validation result: {Validator.Validate(bike)}");


        }
    }
}