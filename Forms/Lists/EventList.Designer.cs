namespace Game_Café_Demonstration_Program
{
    partial class EventList
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
            this.Back = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.DateData = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.ReturnToMenuButton = new System.Windows.Forms.Button();
            this.NamesData = new System.Windows.Forms.Label();
            this.TimeData = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.HardwareNames = new System.Windows.Forms.Label();
            this.Teams = new System.Windows.Forms.Label();
            this.TeamData = new System.Windows.Forms.Label();
            this.NumOfTeamMembers = new System.Windows.Forms.Label();
            this.NumTeamMemberData = new System.Windows.Forms.Label();
            this.Game = new System.Windows.Forms.Label();
            this.GameData = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(13, 13);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.36467F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.36467F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.36467F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.21102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.32625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.36871F));
            this.tableLayoutPanel1.Controls.Add(this.RegisterButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DateData, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Date, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReturnToMenuButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.NamesData, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TimeData, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Time, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.HardwareNames, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Teams, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.TeamData, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.NumOfTeamMembers, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.NumTeamMemberData, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.Game, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.GameData, 6, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(980, 463);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(5, 75);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(64, 23);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // DateData
            // 
            this.DateData.AutoSize = true;
            this.DateData.Location = new System.Drawing.Point(216, 72);
            this.DateData.Name = "DateData";
            this.DateData.Size = new System.Drawing.Size(22, 13);
            this.DateData.TabIndex = 13;
            this.DateData.Text = "XD";
            // 
            // Date
            // 
            this.Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(216, 57);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(131, 13);
            this.Date.TabIndex = 12;
            this.Date.Text = "Date";
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
            // NamesData
            // 
            this.NamesData.AutoSize = true;
            this.NamesData.Location = new System.Drawing.Point(77, 72);
            this.NamesData.Name = "NamesData";
            this.NamesData.Size = new System.Drawing.Size(101, 13);
            this.NamesData.TabIndex = 6;
            this.NamesData.Text = "Enter The Gungeon";
            // 
            // TimeData
            // 
            this.TimeData.AutoSize = true;
            this.TimeData.Location = new System.Drawing.Point(355, 72);
            this.TimeData.Name = "TimeData";
            this.TimeData.Size = new System.Drawing.Size(19, 13);
            this.TimeData.TabIndex = 7;
            this.TimeData.Text = "18";
            // 
            // Time
            // 
            this.Time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(355, 57);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(131, 13);
            this.Time.TabIndex = 2;
            this.Time.Text = "Time";
            // 
            // HardwareNames
            // 
            this.HardwareNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HardwareNames.AutoSize = true;
            this.HardwareNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardwareNames.Location = new System.Drawing.Point(77, 57);
            this.HardwareNames.Name = "HardwareNames";
            this.HardwareNames.Size = new System.Drawing.Size(131, 13);
            this.HardwareNames.TabIndex = 1;
            this.HardwareNames.Text = "Name";
            // 
            // Teams
            // 
            this.Teams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Teams.AutoSize = true;
            this.Teams.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teams.Location = new System.Drawing.Point(494, 57);
            this.Teams.Name = "Teams";
            this.Teams.Size = new System.Drawing.Size(129, 13);
            this.Teams.TabIndex = 14;
            this.Teams.Text = "Teams";
            // 
            // TeamData
            // 
            this.TeamData.AutoSize = true;
            this.TeamData.Location = new System.Drawing.Point(494, 72);
            this.TeamData.Name = "TeamData";
            this.TeamData.Size = new System.Drawing.Size(19, 13);
            this.TeamData.TabIndex = 15;
            this.TeamData.Text = "18";
            // 
            // NumOfTeamMembers
            // 
            this.NumOfTeamMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumOfTeamMembers.AutoSize = true;
            this.NumOfTeamMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfTeamMembers.Location = new System.Drawing.Point(631, 44);
            this.NumOfTeamMembers.Name = "NumOfTeamMembers";
            this.NumOfTeamMembers.Size = new System.Drawing.Size(131, 26);
            this.NumOfTeamMembers.TabIndex = 16;
            this.NumOfTeamMembers.Text = "Num Of Team Members";
            // 
            // NumTeamMemberData
            // 
            this.NumTeamMemberData.AutoSize = true;
            this.NumTeamMemberData.Location = new System.Drawing.Point(631, 72);
            this.NumTeamMemberData.Name = "NumTeamMemberData";
            this.NumTeamMemberData.Size = new System.Drawing.Size(19, 13);
            this.NumTeamMemberData.TabIndex = 17;
            this.NumTeamMemberData.Text = "18";
            // 
            // Game
            // 
            this.Game.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Game.AutoSize = true;
            this.Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game.Location = new System.Drawing.Point(770, 57);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(205, 13);
            this.Game.TabIndex = 18;
            this.Game.Text = "Game";
            // 
            // GameData
            // 
            this.GameData.AutoSize = true;
            this.GameData.Location = new System.Drawing.Point(770, 72);
            this.GameData.Name = "GameData";
            this.GameData.Size = new System.Drawing.Size(19, 13);
            this.GameData.TabIndex = 19;
            this.GameData.Text = "18";
            // 
            // EventList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 463);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Back);
            this.Name = "EventList";
            this.Text = "EventList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventList_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.EventList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label DateData;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button ReturnToMenuButton;
        private System.Windows.Forms.Label NamesData;
        private System.Windows.Forms.Label TimeData;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label HardwareNames;
        private System.Windows.Forms.Label Teams;
        private System.Windows.Forms.Label TeamData;
        private System.Windows.Forms.Label NumOfTeamMembers;
        private System.Windows.Forms.Label NumTeamMemberData;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label Game;
        private System.Windows.Forms.Label GameData;
    }
}