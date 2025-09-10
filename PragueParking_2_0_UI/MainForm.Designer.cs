namespace PragueParking_2_0_UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadGarageToolStripMenuItem = new ToolStripMenuItem();
            saveGarageToolStripMenuItem = new ToolStripMenuItem();
            exitProgramToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            openConfigToolStripMenuItem = new ToolStripMenuItem();
            resetGarageToolStripMenuItem = new ToolStripMenuItem();
            buttonParkVehicle = new Button();
            buttonReturnVehicle = new Button();
            buttonFindVehicle = new Button();
            buttonMoveVehicle = new Button();
            dataGridViewMap = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMap).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(869, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadGarageToolStripMenuItem, saveGarageToolStripMenuItem, exitProgramToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadGarageToolStripMenuItem
            // 
            loadGarageToolStripMenuItem.Name = "loadGarageToolStripMenuItem";
            loadGarageToolStripMenuItem.Size = new Size(216, 34);
            loadGarageToolStripMenuItem.Text = "Load garage";
            loadGarageToolStripMenuItem.Click += loadGarageToolStripMenuItem_Click;
            // 
            // saveGarageToolStripMenuItem
            // 
            saveGarageToolStripMenuItem.Name = "saveGarageToolStripMenuItem";
            saveGarageToolStripMenuItem.Size = new Size(216, 34);
            saveGarageToolStripMenuItem.Text = "Save garage";
            saveGarageToolStripMenuItem.Click += saveGarageToolStripMenuItem_Click;
            // 
            // exitProgramToolStripMenuItem
            // 
            exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            exitProgramToolStripMenuItem.Size = new Size(216, 34);
            exitProgramToolStripMenuItem.Text = "Exit program";
            exitProgramToolStripMenuItem.Click += exitProgramToolStripMenuItem_Click;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openConfigToolStripMenuItem, resetGarageToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(81, 29);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // openConfigToolStripMenuItem
            // 
            openConfigToolStripMenuItem.Name = "openConfigToolStripMenuItem";
            openConfigToolStripMenuItem.Size = new Size(225, 34);
            openConfigToolStripMenuItem.Text = "Open config...";
            openConfigToolStripMenuItem.Click += openConfigToolStripMenuItem_Click;
            // 
            // resetGarageToolStripMenuItem
            // 
            resetGarageToolStripMenuItem.Name = "resetGarageToolStripMenuItem";
            resetGarageToolStripMenuItem.Size = new Size(225, 34);
            resetGarageToolStripMenuItem.Text = "Reset garage";
            resetGarageToolStripMenuItem.Click += resetGarageToolStripMenuItem_Click;
            // 
            // buttonParkVehicle
            // 
            buttonParkVehicle.Location = new Point(37, 58);
            buttonParkVehicle.Name = "buttonParkVehicle";
            buttonParkVehicle.Size = new Size(139, 56);
            buttonParkVehicle.TabIndex = 1;
            buttonParkVehicle.Text = "Park Vehicle";
            buttonParkVehicle.UseVisualStyleBackColor = true;
            buttonParkVehicle.Click += buttonParkVehicle_Click;
            // 
            // buttonReturnVehicle
            // 
            buttonReturnVehicle.Location = new Point(37, 120);
            buttonReturnVehicle.Name = "buttonReturnVehicle";
            buttonReturnVehicle.Size = new Size(139, 56);
            buttonReturnVehicle.TabIndex = 1;
            buttonReturnVehicle.Text = "Return Vehicle";
            buttonReturnVehicle.UseVisualStyleBackColor = true;
            buttonReturnVehicle.Click += buttonReturnVehicle_Click;
            // 
            // buttonFindVehicle
            // 
            buttonFindVehicle.Location = new Point(37, 182);
            buttonFindVehicle.Name = "buttonFindVehicle";
            buttonFindVehicle.Size = new Size(139, 56);
            buttonFindVehicle.TabIndex = 1;
            buttonFindVehicle.Text = "Find Vehicle";
            buttonFindVehicle.UseVisualStyleBackColor = true;
            buttonFindVehicle.Click += buttonFindVehicle_Click;
            // 
            // buttonMoveVehicle
            // 
            buttonMoveVehicle.Location = new Point(37, 244);
            buttonMoveVehicle.Name = "buttonMoveVehicle";
            buttonMoveVehicle.Size = new Size(139, 56);
            buttonMoveVehicle.TabIndex = 1;
            buttonMoveVehicle.Text = "Move Vehicle";
            buttonMoveVehicle.UseVisualStyleBackColor = true;
            buttonMoveVehicle.Click += buttonMoveVehicle_Click;
            // 
            // dataGridViewMap
            // 
            dataGridViewMap.AllowUserToAddRows = false;
            dataGridViewMap.AllowUserToDeleteRows = false;
            dataGridViewMap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMap.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewMap.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMap.EnableHeadersVisualStyles = false;
            dataGridViewMap.Location = new Point(349, 58);
            dataGridViewMap.MultiSelect = false;
            dataGridViewMap.Name = "dataGridViewMap";
            dataGridViewMap.ReadOnly = true;
            dataGridViewMap.RowHeadersVisible = false;
            dataGridViewMap.RowHeadersWidth = 62;
            dataGridViewMap.RowTemplate.Height = 40;
            dataGridViewMap.ScrollBars = ScrollBars.None;
            dataGridViewMap.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewMap.Size = new Size(500, 500);
            dataGridViewMap.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 577);
            Controls.Add(dataGridViewMap);
            Controls.Add(buttonMoveVehicle);
            Controls.Add(buttonFindVehicle);
            Controls.Add(buttonReturnVehicle);
            Controls.Add(buttonParkVehicle);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prague Parking 2.0 by John Sjödin";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadGarageToolStripMenuItem;
        private ToolStripMenuItem saveGarageToolStripMenuItem;
        private ToolStripMenuItem exitProgramToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem openConfigToolStripMenuItem;
        private ToolStripMenuItem resetGarageToolStripMenuItem;
        private Button buttonParkVehicle;
        private Button buttonReturnVehicle;
        private Button buttonFindVehicle;
        private Button buttonMoveVehicle;
        private DataGridView dataGridViewMap;
    }
}
