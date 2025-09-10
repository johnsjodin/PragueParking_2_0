using PragueParking_2_0_Logic;

namespace PragueParking_2_0_UI
{
    public partial class MoveVehicleForm : Form
    {
        public MoveVehicleForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            // Denna metod hanterar flyttning av ett fordon till en ny parkeringsplats.
            string registration = textBoxRegNumber.Text.Trim().ToUpper();
            if (!ValidateRegistration.TryValidateRegistration(registration, out string error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var spot = GarageManager.CurrentGarage.FindVehicle(registration);
            if (spot == null)
            {
                MessageBox.Show("Vehicle not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int newSpotNumber;
            if (!int.TryParse(textBoxNewSpot.Text.Trim(), out newSpotNumber) || newSpotNumber < 1 || newSpotNumber > GarageManager.CurrentGarage.ParkingSpots.Count)
            {
                MessageBox.Show("Invalid parking spot number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ParkingSpot newSpot = GarageManager.CurrentGarage.ParkingSpots.FirstOrDefault(s => s.SpotNumber == newSpotNumber);
            bool moved = GarageManager.CurrentGarage.MoveVehicle(registration, newSpot);
            if (!moved)
            {
                MessageBox.Show("Failed to move vehicle. Spot may be occupied or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GarageManager.SaveGarage();
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
