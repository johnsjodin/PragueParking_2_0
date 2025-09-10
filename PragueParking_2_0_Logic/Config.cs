namespace PragueParking_2_0_Logic
{
    public class Config
    {
        public int NumberOfSpots { get; set; }
        public double SpotSize { get; set; }
        public int FreeMinutes { get; set; }

        public Dictionary<string, VehicleTypeInfo> VehicleTypes { get; set; } = new();
    }
}
