namespace Game_Café_Demonstration_Program
{
    partial class AccountList
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
            this.UsernameData = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.ReturnToMenuButton = new System.Windows.Forms.Button();
            this.GameNamesData = new System.Windows.Forms.Label();
            this.AgeData = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.HardwareNames = new System.Windows.Forms.Label();
            this.Membership = new System.Windows.Forms.Label();
            this.MembershipData = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.06266F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.06266F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.06266F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.81203F));
            this.tableLayoutPanel1.Controls.Add(this.UsernameData, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Username, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReturnToMenuButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GameNamesData, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AgeData, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Age, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.HardwareNames, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Membership, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.MembershipData, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 521);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // UsernameData
            // 
            this.UsernameData.AutoSize = true;
            this.UsernameData.Location = new System.Drawing.Point(247, 81);
            this.UsernameData.Name = "UsernameData";
            this.UsernameData.Size = new System.Drawing.Size(22, 13);
            this.UsernameData.TabIndex = 13;
            this.UsernameData.Text = "XD";
            // 
            // Username
            // 
            this.Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(247, 66);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(162, 13);
            this.Username.TabIndex = 12;
            this.Username.Text = "Username";
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
            // GameNamesData
            // 
            this.GameNamesData.AutoSize = true;
            this.GameNamesData.Location = new System.Drawing.Point(77, 81);
            this.GameNamesData.Name = "GameNamesData";
            this.GameNamesData.Size = new System.Drawing.Size(101, 13);
            this.GameNamesData.TabIndex = 6;
            this.GameNamesData.Text = "Enter The Gungeon";
            // 
            // AgeData
            // 
            this.AgeData.AutoSize = true;
            this.AgeData.Location = new System.Drawing.Point(417, 81);
            this.AgeData.Name = "AgeData";
            this.AgeData.Size = new System.Drawing.Size(19, 13);
            this.AgeData.TabIndex = 7;
            this.AgeData.Text = "18";
            // 
            // Age
            // 
            this.Age.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(417, 66);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(162, 13);
            this.Age.TabIndex = 2;
            this.Age.Text = "Age";
            // 
            // HardwareNames
            // 
            this.HardwareNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HardwareNames.AutoSize = true;
            this.HardwareNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardwareNames.Location = new System.Drawing.Point(77, 66);
            this.HardwareNames.Name = "HardwareNames";
            this.HardwareNames.Size = new System.Drawing.Size(162, 13);
            this.HardwareNames.TabIndex = 1;
            this.HardwareNames.Text = "Name";
            // 
            // Membership
            // 
            this.Membership.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Membership.AutoSize = true;
            this.Membership.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Membership.Location = new System.Drawing.Point(587, 66);
            this.Membership.Name = "Membership";
            this.Membership.Size = new System.Drawing.Size(164, 13);
            this.Membership.TabIndex = 14;
            this.Membership.Text = "Membership";
            // 
            // MembershipData
            // 
            this.MembershipData.AutoSize = true;
            this.MembershipData.Location = new System.Drawing.Point(587, 81);
            this.MembershipData.Name = "MembershipData";
            this.MembershipData.Size = new System.Drawing.Size(19, 13);
            this.MembershipData.TabIndex = 15;
            this.MembershipData.Text = "18";
            // 
            // AccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 521);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AccountList";
            this.Text = "AccountList";
            this.VisibleChanged += new System.EventHandler(this.AccountList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label UsernameData;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button ReturnToMenuButton;
        private System.Windows.Forms.Label GameNamesData;
        private System.Windows.Forms.Label AgeData;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label HardwareNames;
        private System.Windows.Forms.Label Membership;
        private System.Windows.Forms.Label MembershipData;
    }
}