namespace PragueParking_2_0_UI
{
    partial class ReturnVehicleForm
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
            textBoxRegNumber = new TextBox();
            buttonCancel = new Button();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // labelRegNumber
            // 
            labelRegNumber.AutoSize = true;
            labelRegNumber.Location = new Point(54, 63);
            labelRegNumber.Name = "labelRegNumber";
            labelRegNumber.Size = new Size(177, 25);
            labelRegNumber.TabIndex = 0;
            labelRegNumber.Text = "Registration number:";
            // 
            // textBoxRegNumber
            // 
            textBoxRegNumber.Location = new Point(258, 60);
            textBoxRegNumber.MaxLength = 6;
            textBoxRegNumber.Name = "textBoxRegNumber";
            textBoxRegNumber.Size = new Size(150, 31);
            textBoxRegNumber.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(140, 150);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(279, 150);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(112, 34);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // ReturnVehicleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 245);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxRegNumber);
            Controls.Add(labelRegNumber);
            Name = "ReturnVehicleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Return Vehicle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRegNumber;
        private TextBox textBoxRegNumber;
        private Button buttonCancel;
        private Button buttonOk;
    }
}