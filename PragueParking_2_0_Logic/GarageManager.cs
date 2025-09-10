using PragueParking_2_0_Data;

namespace PragueParking_2_0_Logic
{
    // Denna klass används för att hantera parkeringsgaraget och dess platser.
    public static class GarageManager
    {
        public static ParkingGarage CurrentGarage { get; private set; }

        private static readonly string garagePath = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "jsonfiles", "garage.json"));

        public static void LoadOrCreateGarage()
        {
            if (File.Exists(garagePath))
            {
                var spots = FileHandler.LoadDataFromJson<List<ParkingSpot>>(garagePath);
                CurrentGarage = new ParkingGarage(spots);
            }
            else
            {
                ConfigManager.LoadOrCreateConfig();
                CurrentGarage = new ParkingGarage();
                CurrentGarage.Reset(ConfigManager.CurrentConfig.NumberOfSpots);
            }
        }
        public static void SaveGarage()
        {
            FileHandler.SaveDataToJson(garagePath, CurrentGarage.ParkingSpots);
        }
        public static void ResetGarage()
        {
            CurrentGarage.Reset(ConfigManager.CurrentConfig.NumberOfSpots);
            SaveGarage();
        }
    }
}
