using Models_ReadMe_Exercise_2.Interfaces;

namespace Models_ReadMe_Exercise_2
{
    public class CarCentre: ICarWash, IGusPump, IRepairService
    {
        public string WashCar()
        {
            return "We are washing your car";
        }
        public string WashTruck()
        {
            return "We are washing your truck";
        }
        public string CheckVehicle()
        {
            return "We are cheking your vehicle";
        }
        public string FixVehicle()
        {
            return "We are fixing your vehicle";
        }
        public string PumpGas()
        {
            return "Gas is pumped";
        }

    }
}
