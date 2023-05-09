namespace Models_ReadMe_Exercise_1
{
    public static class Validator
    {
        public static bool Validate(Vehicle vehicle)
        {
            if(vehicle.Id == 0 && vehicle.Type == null && vehicle.YearOfProduction == 0)
            {
                return false;
            }

            return true;
        }
    }
}
