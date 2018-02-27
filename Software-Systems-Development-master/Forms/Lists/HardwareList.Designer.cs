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
            this.BookByName = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.Label();
            this.ReturnToMenuButton = new System.Windows.Forms.Button();
            this.HardwareNames = new System.Windows.Forms.Label();
            this.HardwareNamesData = new System.Windows.Forms.Label();
            this.DateTimeData = new System.Windows.Forms.Label();
            this.DurationsData = new System.Windows.Forms.Label();
            this.PriceData = new System.Windows.Forms.Label();
            this.BookByNameData = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.BookByName, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.Price, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Duration, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.DateTime, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReturnToMenuButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HardwareNames, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.HardwareNamesData, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DateTimeData, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.DurationsData, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.PriceData, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.BookByNameData, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.RegisterButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1224, 682);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // BookByName
            // 
            this.BookByName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookByName.AutoSize = true;
            this.BookByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookByName.Location = new System.Drawing.Point(997, 90);
            this.BookByName.Name = "BookByName";
            this.BookByName.Size = new System.Drawing.Size(222, 13);
            this.BookByName.TabIndex = 5;
            this.BookByName.Text = "Name";
            // 
            // Price
            // 
            this.Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(767, 90);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(222, 13);
            this.Price.TabIndex = 4;
            this.Price.Text = "Price (£)";
            // 
            // Duration
            // 
            this.Duration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Duration.AutoSize = true;
            this.Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration.Location = new System.Drawing.Point(537, 90);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(222, 13);
            this.Duration.TabIndex = 3;
            this.Duration.Text = "Duration (hours)";
            // 
            // DateTime
            // 
            this.DateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTime.AutoSize = true;
            this.DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime.Location = new System.Drawing.Point(307, 90);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(222, 13);
            this.DateTime.TabIndex = 2;
            this.DateTime.Text = "Date and Time";
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
            // HardwareNames
            // 
            this.HardwareNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HardwareNames.AutoSize = true;
            this.HardwareNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardwareNames.Location = new System.Drawing.Point(77, 90);
            this.HardwareNames.Name = "HardwareNames";
            this.HardwareNames.Size = new System.Drawing.Size(222, 13);
            this.HardwareNames.TabIndex = 1;
            this.HardwareNames.Text = "Name";
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
            // DateTimeData
            // 
            this.DateTimeData.AutoSize = true;
            this.DateTimeData.Location = new System.Drawing.Point(307, 105);
            this.DateTimeData.Name = "DateTimeData";
            this.DateTimeData.Size = new System.Drawing.Size(89, 39);
            this.DateTimeData.TabIndex = 7;
            this.DateTimeData.Text = "26/02/18 - 16:00\r\n26/02/18 - 16:00\r\n26/02/18 - 16:00";
            // 
            // DurationsData
            // 
            this.DurationsData.AutoSize = true;
            this.DurationsData.Location = new System.Drawing.Point(537, 105);
            this.DurationsData.Name = "DurationsData";
            this.DurationsData.Size = new System.Drawing.Size(13, 39);
            this.DurationsData.TabIndex = 8;
            this.DurationsData.Text = "1\r\n2\r\n3";
            // 
            // PriceData
            // 
            this.PriceData.AutoSize = true;
            this.PriceData.Location = new System.Drawing.Point(767, 105);
            this.PriceData.Name = "PriceData";
            this.PriceData.Size = new System.Drawing.Size(13, 39);
            this.PriceData.TabIndex = 9;
            this.PriceData.Text = "1\r\n2\r\n3";
            // 
            // BookByNameData
            // 
            this.BookByNameData.AutoSize = true;
            this.BookByNameData.Location = new System.Drawing.Point(997, 105);
            this.BookByNameData.Name = "BookByNameData";
            this.BookByNameData.Size = new System.Drawing.Size(85, 39);
            this.BookByNameData.TabIndex = 10;
            this.BookByNameData.Text = "Peter Medyakov\r\nAlister Hartwell\r\nStephen Wong";
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
            // HardwareList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 682);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HardwareList";
            this.Text = "Hardware List";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ReturnToMenuButton;
        private System.Windows.Forms.Label BookByName;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.Label DateTime;
        private System.Windows.Forms.Label HardwareNames;
        private System.Windows.Forms.Label HardwareNamesData;
        private System.Windows.Forms.Label DateTimeData;
        private System.Windows.Forms.Label DurationsData;
        private System.Windows.Forms.Label PriceData;
        private System.Windows.Forms.Label BookByNameData;
        private System.Windows.Forms.Button RegisterButton;
    }
}