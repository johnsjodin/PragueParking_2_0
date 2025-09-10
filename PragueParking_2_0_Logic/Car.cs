namespace PragueParking_2_0_Logic
{
    public class Car : Vehicle
    {
        public Car (string registrationNumber, string vehicleType, double vehicleSize)
            : base(registrationNumber, "Car", vehicleSize)
        {
        }
    }
}
