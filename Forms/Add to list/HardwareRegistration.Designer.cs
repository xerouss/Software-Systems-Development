namespace Game_Café_Demonstration_Program
{
    partial class HardwareRegistration
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HardwareDropDown = new System.Windows.Forms.ComboBox();
            this.HardwareText = new System.Windows.Forms.Label();
            this.PeripheralText = new System.Windows.Forms.Label();
            this.PeripheralDropDown = new System.Windows.Forms.ComboBox();
            this.CancelRegistrationButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.HardwareDropDown, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.HardwareText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PeripheralText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PeripheralDropDown, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CancelRegistrationButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SubmitButton, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(316, 644);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // HardwareDropDown
            // 
            this.HardwareDropDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HardwareDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HardwareDropDown.FormattingEnabled = true;
            this.HardwareDropDown.Items.AddRange(new object[] {
            "Microsoft Xbox One X",
            "Sony Playstation PS4 Pro"});
            this.HardwareDropDown.Location = new System.Drawing.Point(201, 96);
            this.HardwareDropDown.Name = "HardwareDropDown";
            this.HardwareDropDown.Size = new System.Drawing.Size(112, 21);
            this.HardwareDropDown.TabIndex = 0;
            // 
            // HardwareText
            // 
            this.HardwareText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HardwareText.AutoSize = true;
            this.HardwareText.Location = new System.Drawing.Point(111, 100);
            this.HardwareText.Name = "HardwareText";
            this.HardwareText.Size = new System.Drawing.Size(56, 13);
            this.HardwareText.TabIndex = 1;
            this.HardwareText.Text = "Hardware:";
            // 
            // PeripheralText
            // 
            this.PeripheralText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PeripheralText.AutoSize = true;
            this.PeripheralText.Location = new System.Drawing.Point(110, 314);
            this.PeripheralText.Name = "PeripheralText";
            this.PeripheralText.Size = new System.Drawing.Size(57, 13);
            this.PeripheralText.TabIndex = 2;
            this.PeripheralText.Text = "Peripheral:";
            // 
            // PeripheralDropDown
            // 
            this.PeripheralDropDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PeripheralDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PeripheralDropDown.FormattingEnabled = true;
            this.PeripheralDropDown.Items.AddRange(new object[] {
            "Acer R240 24-inch Monitor",
            "Controller"});
            this.PeripheralDropDown.Location = new System.Drawing.Point(201, 310);
            this.PeripheralDropDown.Name = "PeripheralDropDown";
            this.PeripheralDropDown.Size = new System.Drawing.Size(112, 21);
            this.PeripheralDropDown.TabIndex = 3;
            // 
            // CancelRegistrationButton
            // 
            this.CancelRegistrationButton.Location = new System.Drawing.Point(3, 3);
            this.CancelRegistrationButton.Name = "CancelRegistrationButton";
            this.CancelRegistrationButton.Size = new System.Drawing.Size(74, 23);
            this.CancelRegistrationButton.TabIndex = 4;
            this.CancelRegistrationButton.Text = "Cancel";
            this.CancelRegistrationButton.UseVisualStyleBackColor = true;
            this.CancelRegistrationButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitButton.Location = new System.Drawing.Point(219, 524);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // HardwareRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 682);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HardwareRegistration";
            this.Text = "HardwareRegistration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HardwareRegistration_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox HardwareDropDown;
        private System.Windows.Forms.Label HardwareText;
        private System.Windows.Forms.Label PeripheralText;
        private System.Windows.Forms.ComboBox PeripheralDropDown;
        private System.Windows.Forms.Button CancelRegistrationButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}