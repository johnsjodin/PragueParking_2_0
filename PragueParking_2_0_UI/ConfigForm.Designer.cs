namespace PragueParking_2_0_UI
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDownNumberOfSpots = new NumericUpDown();
            labelNumberOfSpots = new Label();
            labelFreeMinutes = new Label();
            numericUpDownFreeMinutes = new NumericUpDown();
            comboBoxVehicleTypes = new ComboBox();
            labelVehicleTypes = new Label();
            labelVehicleSize = new Label();
            textBoxPricePerHour = new Label();
            numericUpDownVehicleSize = new NumericUpDown();
            numericUpDownPricePerHour = new NumericUpDown();
            buttonAddVehicleType = new Button();
            buttonCancel = new Button();
            buttonOk = new Button();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfSpots).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFreeMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVehicleSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPricePerHour).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownNumberOfSpots
            // 
            numericUpDownNumberOfSpots.Location = new Point(353, 68);
            numericUpDownNumberOfSpots.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDownNumberOfSpots.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownNumberOfSpots.Name = "numericUpDownNumberOfSpots";
            numericUpDownNumberOfSpots.Size = new Size(180, 31);
            numericUpDownNumberOfSpots.TabIndex = 0;
            numericUpDownNumberOfSpots.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelNumberOfSpots
            // 
            labelNumberOfSpots.AutoSize = true;
            labelNumberOfSpots.Location = new Point(103, 70);
            labelNumberOfSpots.Name = "labelNumberOfSpots";
            labelNumberOfSpots.Size = new Size(217, 25);
            labelNumberOfSpots.TabIndex = 1;
            labelNumberOfSpots.Text = "Number of parking spots:";
            // 
            // labelFreeMinutes
            // 
            labelFreeMinutes.AutoSize = true;
            labelFreeMinutes.Location = new Point(114, 140);
            labelFreeMinutes.Name = "labelFreeMinutes";
            labelFreeMinutes.Size = new Size(206, 25);
            labelFreeMinutes.TabIndex = 2;
            labelFreeMinutes.Text = "Number of free minutes:";
            // 
            // numericUpDownFreeMinutes
            // 
            numericUpDownFreeMinutes.Location = new Point(353, 138);
            numericUpDownFreeMinutes.Name = "numericUpDownFreeMinutes";
            numericUpDownFreeMinutes.Size = new Size(180, 31);
            numericUpDownFreeMinutes.TabIndex = 3;
            // 
            // comboBoxVehicleTypes
            // 
            comboBoxVehicleTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVehicleTypes.FormattingEnabled = true;
            comboBoxVehicleTypes.Location = new Point(353, 230);
            comboBoxVehicleTypes.Name = "comboBoxVehicleTypes";
            comboBoxVehicleTypes.Size = new Size(182, 33);
            comboBoxVehicleTypes.TabIndex = 4;
            comboBoxVehicleTypes.SelectedIndexChanged += comboBoxVehicleTypes_SelectedIndexChanged;
            // 
            // labelVehicleTypes
            // 
            labelVehicleTypes.AutoSize = true;
            labelVehicleTypes.Location = new Point(44, 233);
            labelVehicleTypes.Name = "labelVehicleTypes";
            labelVehicleTypes.Size = new Size(276, 25);
            labelVehicleTypes.TabIndex = 5;
            labelVehicleTypes.Text = "Choose vehicle type to configure:";
            // 
            // labelVehicleSize
            // 
            labelVehicleSize.AutoSize = true;
            labelVehicleSize.Location = new Point(79, 289);
            labelVehicleSize.Name = "labelVehicleSize";
            labelVehicleSize.Size = new Size(241, 25);
            labelVehicleSize.TabIndex = 6;
            labelVehicleSize.Text = "Number of vehicles per spot:";
            // 
            // textBoxPricePerHour
            // 
            textBoxPricePerHour.AutoSize = true;
            textBoxPricePerHour.Location = new Point(194, 347);
            textBoxPricePerHour.Name = "textBoxPricePerHour";
            textBoxPricePerHour.Size = new Size(126, 25);
            textBoxPricePerHour.TabIndex = 7;
            textBoxPricePerHour.Text = "Price per hour:";
            // 
            // numericUpDownVehicleSize
            // 
            numericUpDownVehicleSize.Location = new Point(353, 287);
            numericUpDownVehicleSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownVehicleSize.Name = "numericUpDownVehicleSize";
            numericUpDownVehicleSize.Size = new Size(180, 31);
            numericUpDownVehicleSize.TabIndex = 8;
            numericUpDownVehicleSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownPricePerHour
            // 
            numericUpDownPricePerHour.Location = new Point(353, 345);
            numericUpDownPricePerHour.Name = "numericUpDownPricePerHour";
            numericUpDownPricePerHour.Size = new Size(180, 31);
            numericUpDownPricePerHour.TabIndex = 9;
            // 
            // buttonAddVehicleType
            // 
            buttonAddVehicleType.Location = new Point(44, 439);
            buttonAddVehicleType.Name = "buttonAddVehicleType";
            buttonAddVehicleType.Size = new Size(198, 34);
            buttonAddVehicleType.TabIndex = 10;
            buttonAddVehicleType.Text = "Add new vehicle type";
            buttonAddVehicleType.UseVisualStyleBackColor = true;
            buttonAddVehicleType.Click += buttonAddVehicleType_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(354, 494);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(477, 494);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(112, 34);
            buttonOk.TabIndex = 12;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(79, 494);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(165, 34);
            buttonSave.TabIndex = 13;
            buttonSave.Text = "Save changes";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 560);
            Controls.Add(buttonSave);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAddVehicleType);
            Controls.Add(numericUpDownPricePerHour);
            Controls.Add(numericUpDownVehicleSize);
            Controls.Add(textBoxPricePerHour);
            Controls.Add(labelVehicleSize);
            Controls.Add(labelVehicleTypes);
            Controls.Add(comboBoxVehicleTypes);
            Controls.Add(numericUpDownFreeMinutes);
            Controls.Add(labelFreeMinutes);
            Controls.Add(labelNumberOfSpots);
            Controls.Add(numericUpDownNumberOfSpots);
            Name = "ConfigForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfigForm";
            Load += ConfigForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfSpots).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFreeMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVehicleSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPricePerHour).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownNumberOfSpots;
        private Label labelNumberOfSpots;
        private Label labelFreeMinutes;
        private NumericUpDown numericUpDownFreeMinutes;
        private ComboBox comboBoxVehicleTypes;
        private Label labelVehicleTypes;
        private Label labelVehicleSize;
        private Label textBoxPricePerHour;
        private NumericUpDown numericUpDownVehicleSize;
        private NumericUpDown numericUpDownPricePerHour;
        private Button buttonAddVehicleType;
        private Button buttonCancel;
        private Button buttonOk;
        private Button buttonSave;
    }
}