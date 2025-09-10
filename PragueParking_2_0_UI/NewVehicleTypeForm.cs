using PragueParking_2_0_Logic;

namespace PragueParking_2_0_UI
{
    public partial class NewVehicleTypeForm : Form
    {
        // Denna klass hanterar skapandet av nya fordonstyper i parkeringssystemet.
        public NewVehicleTypeForm()
        {
            InitializeComponent();
        }
        public bool SaveNewVehicleType()
        {
            string name = textBoxVehicleType.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vehicle type name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ConfigManager.CurrentConfig.VehicleTypes.ContainsKey(name))
            {
                MessageBox.Show("Vehicle type already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            double spotSize = ConfigManager.CurrentConfig.SpotSize;
            int vehicleSize = (int)numericUpDownVehicleSize.Value;

            var info = new VehicleTypeInfo
            {
                // Beräknar storleken på fordonet från användarens inmatning
                VehicleSize = spotSize / vehicleSize,
                PricePerHour = (int)numericUpDownPricePerHour.Value
            };

            ConfigManager.CurrentConfig.VehicleTypes.Add(name, info);
            ConfigManager.SaveConfig();
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (SaveNewVehicleType())
            {
                MessageBox.Show("New vehicle type saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (SaveNewVehicleType())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
