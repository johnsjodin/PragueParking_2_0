namespace PragueParking_2_0_Logic
{
    public class ParkingGarage
    {
        // Denna klass innehåller all logik för hantering av parkeringsplatser i garaget.
        public List<ParkingSpot> ParkingSpots { get; set; }
        public ParkingGarage()
        {
            ParkingSpots = new List<ParkingSpot>();
        }
        public ParkingGarage(List<ParkingSpot> spots)
        {
            ParkingSpots = spots;
        }
        // Metod för att återställa parkeringsgaraget med antalet platser som anges i konfigurationen.
        public void Reset(int numberOfSpots)
        {
            ParkingSpots.Clear();
            for (int i = 1; i <= numberOfSpots; i++)
            {
                ParkingSpots.Add(new ParkingSpot(i, ConfigManager.CurrentConfig.SpotSize));
            }
        }
        // Metod för att parkera ett fordon i garaget efter att ha kontrollerat
        // att det inte redan finns ett fordon med samma registreringsnummer
        // och att det finns en ledig parkeringsplats som kan rymma fordonet.
        public ParkingSpot ParkVehicle(Vehicle vehicle)
        {
            foreach (var spot in ParkingSpots)
            {
                if (spot.HasRegistration(vehicle.RegistrationNumber))
                    return null;
            }
            foreach (var spot in ParkingSpots)
            {
                if (spot.CanFitVehicle(vehicle))
                {
                    spot.Vehicles.Add(vehicle);
                    return spot;
                }
            }
            return null;
        }
        // Metod för att hitta en parkeringsplats baserat på registreringsnumret på fordonet.
        public ParkingSpot FindVehicle(string regNumber)
        {
            foreach (var spot in ParkingSpots)
            {
                if (spot.HasRegistration(regNumber))
                {
                    return spot;
                }
            }
            return null;
        }
        // Metod för att ta bort ett fordon från garaget baserat på dess registreringsnummer.
        public bool RemoveVehicle(string regNumber)
        {
            var spot = FindVehicle(regNumber);
            if (spot != null)
            {
                var vehicle = spot.Vehicles.FirstOrDefault(v => v.RegistrationNumber == regNumber);
                if (vehicle != null)
                {
                    spot.Vehicles.Remove(vehicle);
                    return true;
                }
            }
            return false;
        }
        // Metod för att flytta ett fordon från en parkeringsplats till en annan
        // efter att ha kontrollerat att det finns en ledig plats som kan rymma fordonet.
        public bool MoveVehicle(string regNumber, ParkingSpot newSpot)
        {
            var currentSpot = FindVehicle(regNumber);
            if (currentSpot == null || newSpot == null || !newSpot.CanFitVehicle(currentSpot.Vehicles.First(v => v.RegistrationNumber == regNumber)))
            {
                return false;
            }
            var vehicle = currentSpot.Vehicles.First(v => v.RegistrationNumber == regNumber);
            currentSpot.Vehicles.Remove(vehicle);
            newSpot.Vehicles.Add(vehicle);
            return true;
        }
    }
}
