using PragueParking_2_0_Logic;

namespace PragueParking_2_0_UI
{
    public partial class FindVehicleForm : Form
    {
        public FindVehicleForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string registration = textBoxRegNumber.Text.Trim().ToUpper();

            if (!ValidateRegistration.TryValidateRegistration(registration, out string error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ParkingSpot spotNumber = GarageManager.CurrentGarage.FindVehicle(registration);

            if (spotNumber == null)
            {
                MessageBox.Show("Vehicle not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"Vehicle found in spot {spotNumber.SpotNumber}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
