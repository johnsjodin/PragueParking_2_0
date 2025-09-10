namespace PragueParking_2_0_UI
{
    partial class ParkVehicleForm
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
            comboBoxVehicleTypes = new ComboBox();
            textBoxRegNumber = new TextBox();
            labelVehicleType = new Label();
            labelRegNumber = new Label();
            buttonCancel = new Button();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // comboBoxVehicleTypes
            // 
            comboBoxVehicleTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVehicleTypes.FormattingEnabled = true;
            comboBoxVehicleTypes.Location = new Point(227, 52);
            comboBoxVehicleTypes.Name = "comboBoxVehicleTypes";
            comboBoxVehicleTypes.Size = new Size(182, 33);
            comboBoxVehicleTypes.TabIndex = 0;
            // 
            // textBoxRegNumber
            // 
            textBoxRegNumber.Location = new Point(227, 129);
            textBoxRegNumber.MaxLength = 6;
            textBoxRegNumber.Name = "textBoxRegNumber";
            textBoxRegNumber.Size = new Size(182, 31);
            textBoxRegNumber.TabIndex = 1;
            // 
            // labelVehicleType
            // 
            labelVehicleType.AutoSize = true;
            labelVehicleType.Location = new Point(69, 55);
            labelVehicleType.Name = "labelVehicleType";
            labelVehicleType.Size = new Size(133, 25);
            labelVehicleType.TabIndex = 2;
            labelVehicleType.Text = "Type of vehicle:";
            // 
            // labelRegNumber
            // 
            labelRegNumber.AutoSize = true;
            labelRegNumber.Location = new Point(25, 132);
            labelRegNumber.Name = "labelRegNumber";
            labelRegNumber.Size = new Size(177, 25);
            labelRegNumber.TabIndex = 3;
            labelRegNumber.Text = "Registration number:";
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(193, 221);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(330, 221);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(112, 34);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // ParkVehicleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 292);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancel);
            Controls.Add(labelRegNumber);
            Controls.Add(labelVehicleType);
            Controls.Add(textBoxRegNumber);
            Controls.Add(comboBoxVehicleTypes);
            Name = "ParkVehicleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkVehicleForm";
            Load += ParkVehicleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxVehicleTypes;
        private TextBox textBoxRegNumber;
        private Label labelVehicleType;
        private Label labelRegNumber;
        private Button buttonCancel;
        private Button buttonOk;
    }
}