namespace Game_Café_Demonstration_Program
{
    partial class EventRegistration
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
            this.Cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.GameLabel = new System.Windows.Forms.Label();
            this.GameDropdown = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Time = new System.Windows.Forms.Label();
            this.TimeValue = new System.Windows.Forms.ComboBox();
            this.NumOfTeams = new System.Windows.Forms.Label();
            this.TeamMembers = new System.Windows.Forms.Label();
            this.Teams = new System.Windows.Forms.NumericUpDown();
            this.NumOfMembers = new System.Windows.Forms.NumericUpDown();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Teams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cancel.Location = new System.Drawing.Point(3, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(74, 23);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.54733F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.45267F));
            this.tableLayoutPanel1.Controls.Add(this.Cancel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.NameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.NameText, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.GameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.GameDropdown, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Date, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.monthCalendar1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Time, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TimeValue, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.NumOfTeams, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TeamMembers, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Teams, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.NumOfMembers, 2, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.80269F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.80269F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.38986F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.65465F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.17505F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.17505F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 644);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(108, 41);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // NameText
            // 
            this.NameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameText.Location = new System.Drawing.Point(196, 37);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(349, 20);
            this.NameText.TabIndex = 2;
            // 
            // GameLabel
            // 
            this.GameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameLabel.AutoSize = true;
            this.GameLabel.Location = new System.Drawing.Point(108, 136);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(38, 13);
            this.GameLabel.TabIndex = 4;
            this.GameLabel.Text = "Game:";
            // 
            // GameDropdown
            // 
            this.GameDropdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameDropdown.FormattingEnabled = true;
            this.GameDropdown.Items.AddRange(new object[] {
            "Counter Strike: Global Offensive"});
            this.GameDropdown.Location = new System.Drawing.Point(274, 132);
            this.GameDropdown.Name = "GameDropdown";
            this.GameDropdown.Size = new System.Drawing.Size(192, 21);
            this.GameDropdown.TabIndex = 5;
            // 
            // Date
            // 
            this.Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(111, 271);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(33, 13);
            this.Date.TabIndex = 3;
            this.Date.Text = "Date:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthCalendar1.Location = new System.Drawing.Point(257, 199);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // Time
            // 
            this.Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(111, 406);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(33, 13);
            this.Time.TabIndex = 7;
            this.Time.Text = "Time:";
            // 
            // TimeValue
            // 
            this.TimeValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeValue.FormattingEnabled = true;
            this.TimeValue.Items.AddRange(new object[] {
            "Morning (9am - 12pm)",
            "Afternoon (12pm - 5pm)",
            "Evening (5pm - 10pm)"});
            this.TimeValue.Location = new System.Drawing.Point(274, 402);
            this.TimeValue.Name = "TimeValue";
            this.TimeValue.Size = new System.Drawing.Size(192, 21);
            this.TimeValue.TabIndex = 8;
            // 
            // NumOfTeams
            // 
            this.NumOfTeams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumOfTeams.AutoSize = true;
            this.NumOfTeams.Location = new System.Drawing.Point(87, 499);
            this.NumOfTeams.Name = "NumOfTeams";
            this.NumOfTeams.Size = new System.Drawing.Size(81, 13);
            this.NumOfTeams.TabIndex = 9;
            this.NumOfTeams.Text = "Num Of Teams:";
            // 
            // TeamMembers
            // 
            this.TeamMembers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TeamMembers.AutoSize = true;
            this.TeamMembers.Location = new System.Drawing.Point(89, 584);
            this.TeamMembers.Name = "TeamMembers";
            this.TeamMembers.Size = new System.Drawing.Size(76, 26);
            this.TeamMembers.TabIndex = 10;
            this.TeamMembers.Text = "Num Of Team Members:";
            // 
            // Teams
            // 
            this.Teams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Teams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Teams.Location = new System.Drawing.Point(310, 497);
            this.Teams.Name = "Teams";
            this.Teams.Size = new System.Drawing.Size(120, 16);
            this.Teams.TabIndex = 11;
            // 
            // NumOfMembers
            // 
            this.NumOfMembers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumOfMembers.Location = new System.Drawing.Point(310, 587);
            this.NumOfMembers.Name = "NumOfMembers";
            this.NumOfMembers.Size = new System.Drawing.Size(120, 20);
            this.NumOfMembers.TabIndex = 12;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitButton.Location = new System.Drawing.Point(965, 722);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // EventRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 757);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.SubmitButton);
            this.Name = "EventRegistration";
            this.Text = "EventRegistration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventRegistration_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Teams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label GameLabel;
        private System.Windows.Forms.ComboBox GameDropdown;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.ComboBox TimeValue;
        private System.Windows.Forms.Label NumOfTeams;
        private System.Windows.Forms.Label TeamMembers;
        private System.Windows.Forms.NumericUpDown Teams;
        private System.Windows.Forms.NumericUpDown NumOfMembers;
    }
}