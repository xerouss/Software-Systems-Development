namespace Game_Café_Demonstration_Program
{
    partial class TeamBooking
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
            this.NameText = new System.Windows.Forms.TextBox();
            this.TeamName = new System.Windows.Forms.Label();
            this.Event = new System.Windows.Forms.Label();
            this.EventDropDown = new System.Windows.Forms.ComboBox();
            this.CancelRegistrationButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ListOfTeams = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tableLayoutPanel1.Controls.Add(this.NameText, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TeamName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Event, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EventDropDown, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CancelRegistrationButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SubmitButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.ListOfTeams, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 644);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // NameText
            // 
            this.NameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameText.Location = new System.Drawing.Point(287, 75);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(280, 20);
            this.NameText.TabIndex = 3;
            // 
            // TeamName
            // 
            this.TeamName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TeamName.AutoSize = true;
            this.TeamName.Location = new System.Drawing.Point(148, 79);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(68, 13);
            this.TeamName.TabIndex = 1;
            this.TeamName.Text = "Team Name:";
            // 
            // Event
            // 
            this.Event.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Event.AutoSize = true;
            this.Event.Location = new System.Drawing.Point(163, 250);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(38, 13);
            this.Event.TabIndex = 2;
            this.Event.Text = "Event:";
            // 
            // EventDropDown
            // 
            this.EventDropDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EventDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventDropDown.FormattingEnabled = true;
            this.EventDropDown.Items.AddRange(new object[] {
            "Acer R240 24-inch Monitor",
            "Controller"});
            this.EventDropDown.Location = new System.Drawing.Point(287, 246);
            this.EventDropDown.Name = "EventDropDown";
            this.EventDropDown.Size = new System.Drawing.Size(280, 21);
            this.EventDropDown.TabIndex = 3;
            this.EventDropDown.TextChanged += new System.EventHandler(this.EventDropDown_TextChanged);
            this.EventDropDown.VisibleChanged += new System.EventHandler(this.EventDropDown_VisibleChanged);
            // 
            // CancelRegistrationButton
            // 
            this.CancelRegistrationButton.Location = new System.Drawing.Point(3, 3);
            this.CancelRegistrationButton.Name = "CancelRegistrationButton";
            this.CancelRegistrationButton.Size = new System.Drawing.Size(74, 23);
            this.CancelRegistrationButton.TabIndex = 4;
            this.CancelRegistrationButton.Text = "Cancel";
            this.CancelRegistrationButton.UseVisualStyleBackColor = true;
            this.CancelRegistrationButton.Click += new System.EventHandler(this.CancelRegistrationButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitButton.Location = new System.Drawing.Point(389, 567);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ListOfTeams
            // 
            this.ListOfTeams.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListOfTeams.AutoSize = true;
            this.ListOfTeams.Location = new System.Drawing.Point(386, 421);
            this.ListOfTeams.Name = "ListOfTeams";
            this.ListOfTeams.Size = new System.Drawing.Size(82, 13);
            this.ListOfTeams.TabIndex = 6;
            this.ListOfTeams.Text = "Current Teams: ";
            // 
            // TeamBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 757);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TeamBooking";
            this.Text = "TeamBooking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeamBooking_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.EventDropDown_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TeamName;
        private System.Windows.Forms.Label Event;
        private System.Windows.Forms.ComboBox EventDropDown;
        private System.Windows.Forms.Button CancelRegistrationButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label ListOfTeams;
    }
}