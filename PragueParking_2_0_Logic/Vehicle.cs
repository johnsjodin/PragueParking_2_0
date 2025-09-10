namespace PragueParking_2_0_Logic
{
    public class Vehicle
    {
        public string RegistrationNumber { get; set; }
        public string VehicleType { get; set; }
        public double VehicleSize { get; set; }
        public DateTime ArrivalTime { get; set; } = DateTime.Now;


        public Vehicle(string registrationNumber, string vehicleType, double vehicleSize)
        {
            RegistrationNumber = registrationNumber;
            VehicleType = vehicleType;
            VehicleSize = vehicleSize;
        }
    }
}
