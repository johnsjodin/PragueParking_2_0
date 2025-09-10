using PragueParking_2_0_Logic;

namespace PragueParking_2_0_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Laddar konfiguration och garage när programmet startar
            ConfigManager.LoadOrCreateConfig();
            GarageManager.LoadOrCreateGarage();
            LoadParkingMap();
        }
        private void buttonResetGarage_Click(object sender, EventArgs e)
        {
            GarageManager.ResetGarage();
            LoadParkingMap();
        }
        private void openConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var configForm = new ConfigForm())
            {
                if (configForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Saved changes.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void LoadParkingMap()
        {
            dataGridViewMap.ClearSelection();

            var spots = GarageManager.CurrentGarage.ParkingSpots;
            // Beräkna antalet kolumner och rader baserat på antalet parkeringsplatser
            int columns = 10;
            int rows = (int)Math.Ceiling(spots.Count / (double)columns);

            // Rensa tidigare data i DataGridView
            dataGridViewMap.Columns.Clear();
            dataGridViewMap.Rows.Clear();

            // Lägg till kolumner och rader i DataGridView
            for (int c = 0; c < columns; c++)
                dataGridViewMap.Columns.Add($"col{c}", "");

            dataGridViewMap.Rows.Add(rows);

            // Ställ in bredd och höjd för cellerna i DataGridView
            int cellWidth = dataGridViewMap.Width / columns;
            foreach (DataGridViewColumn column in dataGridViewMap.Columns)
                column.Width = cellWidth;

            int cellHeight = dataGridViewMap.Height / rows;
            for (int r = 0; r < rows; r++)
                dataGridViewMap.Rows[r].Height = cellHeight;

            // Fyll i cellerna med parkeringsplatsnummer och färgkodning
            for (int i = 0; i < spots.Count; i++)
            {
                int row = i / columns;
                int col = i % columns;

                var spot = spots[i];
                var cell = dataGridViewMap[col, row];

                cell.Value = spot.SpotNumber.ToString();

                if (spot.Vehicles.Count == 0)
                    cell.Style.BackColor = Color.LightGreen;
                else
                    cell.Style.BackColor = Color.LightCoral;
            }
            dataGridViewMap.ClearSelection();
        }
        // Menyknapparna öppnar olika formulär för att hantera funktionerna i parkeringssystemet
        private void buttonParkVehicle_Click(object sender, EventArgs e)
        {
            using (var parkForm = new ParkVehicleForm())
            {
                if (parkForm.ShowDialog() == DialogResult.OK)
                {
                    LoadParkingMap();
                }
            }
        }
        private void buttonReturnVehicle_Click(object sender, EventArgs e)
        {
            using (var returnForm = new ReturnVehicleForm())
            {
                if (returnForm.ShowDialog() == DialogResult.OK)
                {
                    LoadParkingMap();
                }
            }
        }
        private void buttonFindVehicle_Click(object sender, EventArgs e)
        {
            using (var findForm = new FindVehicleForm())
            {
                if (findForm.ShowDialog() == DialogResult.OK)
                {
                    LoadParkingMap();
                }
            }
        }
        private void buttonMoveVehicle_Click(object sender, EventArgs e)
        {
            using (var moveForm = new MoveVehicleForm())
            {
                if (moveForm.ShowDialog() == DialogResult.OK)
                {
                    LoadParkingMap();
                }
            }
        }
        private void resetGarageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to reset the garage? This will remove all parked vehicles.", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                GarageManager.ResetGarage();
                LoadParkingMap();
            }
        }
        private void loadGarageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GarageManager.LoadOrCreateGarage();
        }
        private void saveGarageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GarageManager.SaveGarage();
        }
        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
