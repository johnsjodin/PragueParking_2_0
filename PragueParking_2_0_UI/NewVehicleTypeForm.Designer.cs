namespace PragueParking_2_0_UI
{
    partial class NewVehicleTypeForm
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
            labelVehicleType = new Label();
            labelVehicleSize = new Label();
            labelPricePerHour = new Label();
            textBoxVehicleType = new TextBox();
            numericUpDownVehicleSize = new NumericUpDown();
            numericUpDownPricePerHour = new NumericUpDown();
            buttonCancel = new Button();
            buttonOk = new Button();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVehicleSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPricePerHour).BeginInit();
            SuspendLayout();
            // 
            // labelVehicleType
            // 
            labelVehicleType.AutoSize = true;
            labelVehicleType.Location = new Point(68, 44);
            labelVehicleType.Name = "labelVehicleType";
            labelVehicleType.Size = new Size(191, 25);
            labelVehicleType.TabIndex = 0;
            labelVehicleType.Text = "Name the vehicle type:";
            // 
            // labelVehicleSize
            // 
            labelVehicleSize.AutoSize = true;
            labelVehicleSize.Location = new Point(18, 105);
            labelVehicleSize.Name = "labelVehicleSize";
            labelVehicleSize.Size = new Size(241, 25);
            labelVehicleSize.TabIndex = 1;
            labelVehicleSize.Text = "Number of vehicles per spot:";
            // 
            // labelPricePerHour
            // 
            labelPricePerHour.AutoSize = true;
            labelPricePerHour.Location = new Point(133, 170);
            labelPricePerHour.Name = "labelPricePerHour";
            labelPricePerHour.Size = new Size(126, 25);
            labelPricePerHour.TabIndex = 2;
            labelPricePerHour.Text = "Price per hour:";
            // 
            // textBoxVehicleType
            // 
            textBoxVehicleType.Location = new Point(307, 41);
            textBoxVehicleType.Name = "textBoxVehicleType";
            textBoxVehicleType.Size = new Size(180, 31);
            textBoxVehicleType.TabIndex = 3;
            // 
            // numericUpDownVehicleSize
            // 
            numericUpDownVehicleSize.Location = new Point(307, 103);
            numericUpDownVehicleSize.Maximum = new decimal(new int[] { 200, 0, 0, 65536 });
            numericUpDownVehicleSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownVehicleSize.Name = "numericUpDownVehicleSize";
            numericUpDownVehicleSize.Size = new Size(180, 31);
            numericUpDownVehicleSize.TabIndex = 4;
            numericUpDownVehicleSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownPricePerHour
            // 
            numericUpDownPricePerHour.Location = new Point(307, 168);
            numericUpDownPricePerHour.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPricePerHour.Name = "numericUpDownPricePerHour";
            numericUpDownPricePerHour.Size = new Size(180, 31);
            numericUpDownPricePerHour.TabIndex = 5;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(265, 259);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(383, 259);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(112, 34);
            buttonOk.TabIndex = 7;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(18, 259);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(165, 34);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Save new vehicle";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // NewVehicleTypeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 320);
            Controls.Add(buttonSave);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancel);
            Controls.Add(numericUpDownPricePerHour);
            Controls.Add(numericUpDownVehicleSize);
            Controls.Add(textBoxVehicleType);
            Controls.Add(labelPricePerHour);
            Controls.Add(labelVehicleSize);
            Controls.Add(labelVehicleType);
            Name = "NewVehicleTypeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewVehicleTypeForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownVehicleSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPricePerHour).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelVehicleType;
        private Label labelVehicleSize;
        private Label labelPricePerHour;
        private TextBox textBoxVehicleType;
        private NumericUpDown numericUpDownVehicleSize;
        private NumericUpDown numericUpDownPricePerHour;
        private Button buttonCancel;
        private Button buttonOk;
        private Button buttonSave;
    }
}