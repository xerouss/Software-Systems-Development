namespace Game_Café_Demonstration_Program
{
    partial class HardwareList
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
            this.PeripheralData = new System.Windows.Forms.Label();
            this.Peripheral = new System.Windows.Forms.Label();
            this.ReturnToMenuButton = new System.Windows.Forms.Button();
            this.HardwareNamesData = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.HardwareNames = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PeripheralData, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Peripheral, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReturnToMenuButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HardwareNamesData, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.RegisterButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.HardwareNames, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1224, 682);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PeripheralData
            // 
            this.PeripheralData.AutoSize = true;
            this.PeripheralData.Location = new System.Drawing.Point(652, 105);
            this.PeripheralData.Name = "PeripheralData";
            this.PeripheralData.Size = new System.Drawing.Size(42, 13);
            this.PeripheralData.TabIndex = 13;
            this.PeripheralData.Text = "Monitor";
            // 
            // Peripheral
            // 
            this.Peripheral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Peripheral.AutoSize = true;
            this.Peripheral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Peripheral.Location = new System.Drawing.Point(652, 90);
            this.Peripheral.Name = "Peripheral";
            this.Peripheral.Size = new System.Drawing.Size(567, 13);
            this.Peripheral.TabIndex = 12;
            this.Peripheral.Text = "Peripheral";
            // 
            // ReturnToMenuButton
            // 
            this.ReturnToMenuButton.Location = new System.Drawing.Point(5, 5);
            this.ReturnToMenuButton.Name = "ReturnToMenuButton";
            this.ReturnToMenuButton.Size = new System.Drawing.Size(44, 23);
            this.ReturnToMenuButton.TabIndex = 0;
            this.ReturnToMenuButton.Text = "Back";
            this.ReturnToMenuButton.UseVisualStyleBackColor = true;
            this.ReturnToMenuButton.Click += new System.EventHandler(this.ReturnToMenuButton_Click);
            // 
            // HardwareNamesData
            // 
            this.HardwareNamesData.AutoSize = true;
            this.HardwareNamesData.Location = new System.Drawing.Point(77, 105);
            this.HardwareNamesData.Name = "HardwareNamesData";
            this.HardwareNamesData.Size = new System.Drawing.Size(64, 39);
            this.HardwareNamesData.TabIndex = 6;
            this.HardwareNamesData.Text = "Xbox One X\r\nPS4\r\nPC";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(5, 108);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(64, 23);
            this.RegisterButton.TabIndex = 11;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // HardwareNames
            // 
            this.HardwareNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HardwareNames.AutoSize = true;
            this.HardwareNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardwareNames.Location = new System.Drawing.Point(77, 90);
            this.HardwareNames.Name = "HardwareNames";
            this.HardwareNames.Size = new System.Drawing.Size(567, 13);
            this.HardwareNames.TabIndex = 1;
            this.HardwareNames.Text = "Name";
            // 
            // HardwareList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 682);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HardwareList";
            this.Text = "Hardware List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HardwareList_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.HardwareList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ReturnToMenuButton;
        private System.Windows.Forms.Label HardwareNames;
        private System.Windows.Forms.Label HardwareNamesData;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label PeripheralData;
        private System.Windows.Forms.Label Peripheral;
    }
}