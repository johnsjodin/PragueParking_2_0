namespace PragueParking_2_0_Logic
{
    public class ParkingSpot
    {
        public int SpotNumber { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public double SpotSize { get; set; }

        public ParkingSpot(int spotNumber, double spotSize)
        {
            SpotNumber = spotNumber;
            SpotSize = spotSize;
            Vehicles = new List<Vehicle>();
        }
        // Metod för att kontrollera om en parkeringsplats kan rymma ett fordon.
        public bool CanFitVehicle(Vehicle vehicle)
        {
            double totalSize = Vehicles.Sum(v => v.VehicleSize);

            if (totalSize + vehicle.VehicleSize <= SpotSize)
                return true;
            return false;
        }
        // Metod för att kontrollera om en registreringsnummer redan finns i denna parkeringsplats.
        public bool HasRegistration(string registration)
        {
            return Vehicles.Any(v => v.RegistrationNumber == registration);
        }
    }
}
