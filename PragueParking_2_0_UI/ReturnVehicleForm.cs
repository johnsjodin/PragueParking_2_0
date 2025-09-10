using PragueParking_2_0_Logic;

namespace PragueParking_2_0_UI
{
    public partial class ReturnVehicleForm : Form
    {
        public ReturnVehicleForm()
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

            var spot = GarageManager.CurrentGarage.FindVehicle(registration);
            if (spot == null)
            {
                MessageBox.Show("Vehicle not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var vehicle = spot.Vehicles.First(v => v.RegistrationNumber == registration);
            if (vehicle == null)
            {
                MessageBox.Show("Vehicle not found in the specified spot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            bool removed = GarageManager.CurrentGarage.RemoveVehicle(registration);
            if (!removed)
            {
                MessageBox.Show("Failed to remove vehicle. It may not be parked or there is an issue with the garage.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GarageManager.SaveGarage();

            // Det här skickas vidare till ReceiptForm för att visa kvittouppgifter
            string regNumber = vehicle.RegistrationNumber;
            string vehicleType = vehicle.GetType().Name;
            int spotNumber = spot.SpotNumber;
            DateTime arrival = vehicle.ArrivalTime;
            DateTime departure = DateTime.Now;
            TimeSpan parkedTime = departure - arrival;
            int freeMinutes = ConfigManager.CurrentConfig.FreeMinutes;
            double pricePerHour = ConfigManager.CurrentConfig.VehicleTypes[vehicle.VehicleType].PricePerHour;

            double totalHours = Math.Max((parkedTime.TotalMinutes - freeMinutes) / 60.0, 0);
            double cost = Math.Ceiling(totalHours) * pricePerHour;

            using (var receiptForm = new ReceiptForm(regNumber, vehicleType, spotNumber, arrival, departure, freeMinutes, cost))
            {
                receiptForm.ShowDialog();
            }
            Close();
            return;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
