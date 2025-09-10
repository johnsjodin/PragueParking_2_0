using PragueParking_2_0_Logic;

namespace PragueParking_2_0_UI
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            LoadVehicleTypes();
            numericUpDownNumberOfSpots.Value = ConfigManager.CurrentConfig.NumberOfSpots;
            numericUpDownFreeMinutes.Value = ConfigManager.CurrentConfig.FreeMinutes;
        }

        private void LoadVehicleTypes()
        {
            comboBoxVehicleTypes.Items.Clear();

            foreach (var vehicleType in ConfigManager.CurrentConfig.VehicleTypes.Keys)
                comboBoxVehicleTypes.Items.Add(vehicleType);
        }

        private void SaveChanges()
        {
            ConfigManager.CurrentConfig.NumberOfSpots = (int)numericUpDownNumberOfSpots.Value;
            ConfigManager.CurrentConfig.FreeMinutes = (int)numericUpDownFreeMinutes.Value;

            double spotSize = ConfigManager.CurrentConfig.SpotSize;
            int vehicleSize = (int)numericUpDownVehicleSize.Value;

            if (comboBoxVehicleTypes.SelectedItem is string selectedType &&
                ConfigManager.CurrentConfig.VehicleTypes.TryGetValue(selectedType, out var info))
            {
                // Beräknar storleken på fordonet från användarens inmatning
                info.VehicleSize = spotSize / vehicleSize;
                info.PricePerHour = (int)numericUpDownPricePerHour.Value;
            }

            ConfigManager.SaveConfig();
        }

        private void comboBoxVehicleTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVehicleTypes.SelectedItem is not string selectedType) return;

            double spotSize = ConfigManager.CurrentConfig.SpotSize;
            if (ConfigManager.CurrentConfig.VehicleTypes.TryGetValue(selectedType, out var info))
            {
                numericUpDownVehicleSize.Value = (decimal)(spotSize / info.VehicleSize);
                numericUpDownPricePerHour.Value = info.PricePerHour;
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
            MessageBox.Show("Saved changes.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            SaveChanges();
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddVehicleType_Click(object sender, EventArgs e)
        {
            using (var newVehicleTypeForm = new NewVehicleTypeForm())
            {
                if (newVehicleTypeForm.ShowDialog() == DialogResult.OK)
                {
                    LoadVehicleTypes();
                    MessageBox.Show("Saved changes.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
