namespace PragueParking_2_0_UI
{
    partial class ReceiptForm
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
            labelRegNumber = new Label();
            labelSpotNumber = new Label();
            labelArrival = new Label();
            labelDeparture = new Label();
            labelFreeMinutes = new Label();
            labelCost = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // labelVehicleType
            // 
            labelVehicleType.AutoSize = true;
            labelVehicleType.Location = new Point(38, 49);
            labelVehicleType.Name = "labelVehicleType";
            labelVehicleType.Size = new Size(140, 25);
            labelVehicleType.TabIndex = 0;
            labelVehicleType.Text = "labelVehicleType";
            // 
            // labelRegNumber
            // 
            labelRegNumber.AutoSize = true;
            labelRegNumber.Location = new Point(38, 112);
            labelRegNumber.Name = "labelRegNumber";
            labelRegNumber.Size = new Size(144, 25);
            labelRegNumber.TabIndex = 1;
            labelRegNumber.Text = "labelRegNumber";
            // 
            // labelSpotNumber
            // 
            labelSpotNumber.AutoSize = true;
            labelSpotNumber.Location = new Point(38, 176);
            labelSpotNumber.Name = "labelSpotNumber";
            labelSpotNumber.Size = new Size(152, 25);
            labelSpotNumber.TabIndex = 2;
            labelSpotNumber.Text = "labelSpotNumber";
            // 
            // labelArrival
            // 
            labelArrival.AutoSize = true;
            labelArrival.Location = new Point(38, 240);
            labelArrival.Name = "labelArrival";
            labelArrival.Size = new Size(99, 25);
            labelArrival.TabIndex = 3;
            labelArrival.Text = "labelArrival";
            // 
            // labelDeparture
            // 
            labelDeparture.AutoSize = true;
            labelDeparture.Location = new Point(38, 309);
            labelDeparture.Name = "labelDeparture";
            labelDeparture.Size = new Size(128, 25);
            labelDeparture.TabIndex = 4;
            labelDeparture.Text = "labelDeparture";
            // 
            // labelFreeMinutes
            // 
            labelFreeMinutes.AutoSize = true;
            labelFreeMinutes.Location = new Point(38, 377);
            labelFreeMinutes.Name = "labelFreeMinutes";
            labelFreeMinutes.Size = new Size(145, 25);
            labelFreeMinutes.TabIndex = 5;
            labelFreeMinutes.Text = "labelFreeMinutes";
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Location = new Point(38, 480);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(85, 25);
            labelCost.TabIndex = 6;
            labelCost.Text = "labelCost";
            // 
            // buttonClose
            // 
            buttonClose.DialogResult = DialogResult.OK;
            buttonClose.Location = new Point(111, 577);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(112, 34);
            buttonClose.TabIndex = 7;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 660);
            Controls.Add(buttonClose);
            Controls.Add(labelCost);
            Controls.Add(labelFreeMinutes);
            Controls.Add(labelDeparture);
            Controls.Add(labelArrival);
            Controls.Add(labelSpotNumber);
            Controls.Add(labelRegNumber);
            Controls.Add(labelVehicleType);
            Name = "ReceiptForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReceiptForm";
            Load += ReceiptForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelVehicleType;
        private Label labelRegNumber;
        private Label labelSpotNumber;
        private Label labelArrival;
        private Label labelDeparture;
        private Label labelFreeMinutes;
        private Label labelCost;
        private Button buttonClose;
    }
}