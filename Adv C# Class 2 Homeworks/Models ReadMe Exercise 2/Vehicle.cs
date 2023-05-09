using Models_ReadMe_Exercise_2.Interfaces;

namespace Models_ReadMe_Exercise_2
{
    public abstract class Vehicle : IGusPump, IRepairService
    {
        public string Model { get; set; }
        public string YearOfProduction { get; set; }
        public string TypeFuel { get; set; }
        public bool Repeardamage { get; set; }

        public Vehicle(string model, string yearOfProduction, string typeFuel, bool repearDamage)
        {
            Model = model;
            YearOfProduction = yearOfProduction;
            TypeFuel = typeFuel;
            Repeardamage = repearDamage;
        }

        public virtual string Drive()
        {
            return "Your Car is ready for pick up.";
        }
        public string PumpGas()
        {
            return $"{TypeFuel} is pumped to max.";
            
        }

        public string CheckVehicle()
        {
            if(Repeardamage == true)
            {
                return "This car needs to be repear";
            }
            else
            {
                return "This car is not for repear";
            }
        }

        public string FixVehicle()
        {
            if(Repeardamage != false)
            {
                return "This vehicle is been repeard, you will be notify when it is done, take a seat and wait for it";
            }
            else
            {
                return "This vehicle has nothing to be fixed";
            }
        }

    }
}