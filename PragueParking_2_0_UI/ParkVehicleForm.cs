using PragueParking_2_0_Logic;

namespace PragueParking_2_0_UI
{
    public partial class ParkVehicleForm : Form
    {
        // Denna klass hanterar parkering av fordon i parkeringssystemet.
        public ParkVehicleForm()
        {
            InitializeComponent();
        }

        private void ParkVehicleForm_Load(object sender, EventArgs e)
        {
            LoadVehicleTypes();
        }
        private void LoadVehicleTypes()
        {
            comboBoxVehicleTypes.Items.Clear();

            foreach (var vehicleType in ConfigManager.CurrentConfig.VehicleTypes.Keys)
                comboBoxVehicleTypes.Items.Add(vehicleType);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string registration = textBoxRegNumber.Text.Trim().ToUpper();
            string vehicleType = comboBoxVehicleTypes.SelectedItem?.ToString();

            if (!ValidateRegistration.TryValidateRegistration(registration, out string error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(vehicleType))
            {
                MessageBox.Show("Please select a vehicle type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Skapar ett nytt fordon med registreringsnummer, fordonstyp och storlek
            var info = ConfigManager.CurrentConfig.VehicleTypes[vehicleType];
            var vehicle = new Vehicle(registration, vehicleType, info.VehicleSize);
            var spot = GarageManager.CurrentGarage.ParkVehicle(vehicle);

            if (spot != null)
            {
                GarageManager.SaveGarage();
                MessageBox.Show($"Vehicle {registration} parked successfully in spot {spot.SpotNumber}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Could not park vehicle {registration}. It may already be parked or there is no available space.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
