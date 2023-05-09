using Models_ReadMe_Exercise_2.Interfaces;

namespace Models_ReadMe_Exercise_2
{
    public class Truck: Vehicle, ICarWash
    {
        public string TruckRegisterNumber { get; set; }
        public Truck(string model, string yearOfProduction, string typeFuel, bool repearDamage, string truckRegisterNumber):
            base(model, yearOfProduction, typeFuel, repearDamage)
        {
            TruckRegisterNumber = truckRegisterNumber;
        }

        public override string Drive()
        {
            return base.Drive() + $"{TruckRegisterNumber}";
        }

        public string WashTruck()
        {
            return $"Truck with registration: {TruckRegisterNumber} is washed";
        }
        public string WashCar()
        {
            return $"This is not a car";
        }

    }
}
