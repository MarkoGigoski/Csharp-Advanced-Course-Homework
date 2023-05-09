using Models_ReadMe_Exercise_2.Interfaces;

namespace Models_ReadMe_Exercise_2
{
    public class Car: Vehicle, ICarWash
    {
        public string CarId { get; set; }
        
        public Car(string model, string yearOfProduction, string typeFuel, bool repearDamage, string carId):
            base(model, yearOfProduction, typeFuel, repearDamage)
        {
            CarId = carId;
        }

        public override string Drive()
        {
            return base.Drive() + $"{CarId}";
        }
        public string WashCar()
        {
            return $"Car with Id: {CarId} is washed";
        }
        public string WashTruck()
        {
            return $"This is not a truck";
        }

    }
}
