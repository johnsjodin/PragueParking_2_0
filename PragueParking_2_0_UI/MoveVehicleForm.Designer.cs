namespace PragueParking_2_0_UI
{
    partial class MoveVehicleForm
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
            labelRegNumber = new Label();
            labelNewSpot = new Label();
            textBoxRegNumber = new TextBox();
            textBoxNewSpot = new TextBox();
            buttonCancel = new Button();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // labelRegNumber
            // 
            labelRegNumber.AutoSize = true;
            labelRegNumber.Location = new Point(56, 51);
            labelRegNumber.Name = "labelRegNumber";
            labelRegNumber.Size = new Size(177, 25);
            labelRegNumber.TabIndex = 0;
            labelRegNumber.Text = "Registration number:";
            // 
            // labelNewSpot
            // 
            labelNewSpot.AutoSize = true;
            labelNewSpot.Location = new Point(109, 136);
            labelNewSpot.Name = "labelNewSpot";
            labelNewSpot.Size = new Size(124, 25);
            labelNewSpot.TabIndex = 1;
            labelNewSpot.Text = "Move to spot:";
            // 
            // textBoxRegNumber
            // 
            textBoxRegNumber.Location = new Point(266, 48);
            textBoxRegNumber.MaxLength = 6;
            textBoxRegNumber.Name = "textBoxRegNumber";
            textBoxRegNumber.Size = new Size(150, 31);
            textBoxRegNumber.TabIndex = 2;
            // 
            // textBoxNewSpot
            // 
            textBoxNewSpot.Location = new Point(266, 133);
            textBoxNewSpot.MaxLength = 3;
            textBoxNewSpot.Name = "textBoxNewSpot";
            textBoxNewSpot.Size = new Size(150, 31);
            textBoxNewSpot.TabIndex = 3;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(197, 272);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(338, 272);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(112, 34);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // MoveVehicleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 358);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxNewSpot);
            Controls.Add(textBoxRegNumber);
            Controls.Add(labelNewSpot);
            Controls.Add(labelRegNumber);
            Name = "MoveVehicleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MoveVehicleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRegNumber;
        private Label labelNewSpot;
        private TextBox textBoxRegNumber;
        private TextBox textBoxNewSpot;
        private Button buttonCancel;
        private Button buttonOk;
    }
}