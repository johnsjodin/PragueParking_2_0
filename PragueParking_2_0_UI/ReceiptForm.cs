namespace PragueParking_2_0_UI
{
    public partial class ReceiptForm : Form
    {
        private string regNumber;
        private string vehicleType;
        private int spotNumber;
        private DateTime arrival;
        private DateTime departure;
        private int freeMinutes;
        private double cost;
        public ReceiptForm(string regNumber, string vehicleType, int spotNumber,
            DateTime arrival, DateTime departure, int freeMinutes, double cost)
        {
            InitializeComponent();
            this.regNumber = regNumber;
            this.vehicleType = vehicleType;
            this.spotNumber = spotNumber;
            this.arrival = arrival;
            this.departure = departure;
            this.freeMinutes = freeMinutes;
            this.cost = cost;
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            labelRegNumber.Text = $"Registration Number: {regNumber}";
            labelVehicleType.Text = $"Vehicle Type: {vehicleType}";
            labelSpotNumber.Text = $"Spot Number: {spotNumber}";
            labelArrival.Text = $"Arrival Time: {arrival.ToString("g")}";
            labelDeparture.Text = $"Departure Time: {departure.ToString("g")}";
            labelFreeMinutes.Text = $"Free Minutes: {freeMinutes}";
            labelCost.Text = $"Total Cost: {cost} CZK";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
