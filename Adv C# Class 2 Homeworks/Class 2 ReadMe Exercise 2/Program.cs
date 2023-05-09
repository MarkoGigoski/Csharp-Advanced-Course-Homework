using Models_ReadMe_Exercise_2;

namespace Class_2_ReadMe_Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class 2 ReadMe Exercise 2 
            Console.WriteLine("Class 2 Exercise 3");
            /*
            ● Create one abstract class Vehicle with abstract method Drive, and two classes Car and Truck,
            that inherit from Vehicle and override the method Drive.
            ● Create 3 interfaces: 
              - ICarWash that has methods WashCar that works for Cars, and WashTrailer that works for Trailers.
              - IGasPump that has method PumpGas that works for all vehicles
              - IRepairService that has methods CheckVehicle and FixVehicle that work for all vehicles.
            ● Implement each interface in a different class: CarWash, GasPump and RepairService.
            ● Implement all interfaces in one class CarCenter.
            ● Methods can be implemented with Console.Writeline or changing and checking bools
            (ex. isClean, isGasFull, isBroken...
            */

            Car c1 = new Car("Fiat", "2000", "Petrol", true, "SK-7620-AM");
            Car c2 = new Car("Citroen", "2020", "Diesel", false, "SK-8746-JR");

            Console.WriteLine(c1.Drive());
            Console.WriteLine(c1.CheckVehicle());
            Console.WriteLine(c2.FixVehicle());
            Console.WriteLine(c1.FixVehicle());

            Truck t1 = new Truck("Mercedes", "2018", "Petrol", true, "BT-2050-ZR / BT-2051-ZR");
            Truck t2 = new Truck("BMW", "2004", "Diesel", false, "DB-3041-GH / DB-3042-GH");

            Console.WriteLine(t1.Drive());
            Console.WriteLine(t1.PumpGas());
            Console.WriteLine(t2.CheckVehicle());
            Console.WriteLine(t1.FixVehicle());
        }
    }
}