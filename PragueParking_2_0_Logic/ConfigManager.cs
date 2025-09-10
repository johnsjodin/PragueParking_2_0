using PragueParking_2_0_Data;

namespace PragueParking_2_0_Logic
{
    // Denna klass används för att hantera konfigurationen av parkeringssystemet.
    public static class ConfigManager
    {
        public static Config CurrentConfig { get; private set; }

        private static readonly string configPath = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "jsonfiles", "config.json"));

        public static void LoadOrCreateConfig()
        {
            if (File.Exists(configPath))
            {
                CurrentConfig = FileHandler.LoadDataFromJson<Config>(configPath);
            }
            else
            {
                CurrentConfig = new Config
                {
                    NumberOfSpots = 100,
                    SpotSize = 1.0,
                    FreeMinutes = 10,
                    VehicleTypes = new Dictionary<string, VehicleTypeInfo>
                    {
                        { "Car", new VehicleTypeInfo { VehicleSize = 1.0, PricePerHour = 20 } },
                        { "Motorcycle", new VehicleTypeInfo { VehicleSize = 0.5, PricePerHour = 10 } }
                    }
                };
                SaveConfig();
            }
        }
        public static void SaveConfig()
        {
            FileHandler.SaveDataToJson(configPath, CurrentConfig);
        }
    }
}
