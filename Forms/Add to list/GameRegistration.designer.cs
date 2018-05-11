namespace Game_Café_Demonstration_Program
{
    partial class GameRegistration
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
            this.AgeRatingDropdown = new System.Windows.Forms.ComboBox();
            this.GameNameLabel = new System.Windows.Forms.Label();
            this.GameNameText = new System.Windows.Forms.TextBox();
            this.GameRatingLabel = new System.Windows.Forms.Label();
            this.GameHardwareLabel = new System.Windows.Forms.Label();
            this.GameHardwareDropdown = new System.Windows.Forms.ComboBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.Cancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.54733F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.45267F));
            this.tableLayoutPanel1.Controls.Add(this.AgeRatingDropdown, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Cancel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GameNameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GameNameText, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.GameRatingLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.GameHardwareLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.GameHardwareDropdown, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 644);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // AgeRatingDropdown
            // 
            this.AgeRatingDropdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AgeRatingDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgeRatingDropdown.FormattingEnabled = true;
            this.AgeRatingDropdown.Items.AddRange(new object[] {
            "3",
            "7",
            "12",
            "16",
            "18"});
            this.AgeRatingDropdown.Location = new System.Drawing.Point(314, 310);
            this.AgeRatingDropdown.Name = "AgeRatingDropdown";
            this.AgeRatingDropdown.Size = new System.Drawing.Size(112, 21);
            this.AgeRatingDropdown.TabIndex = 6;
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameNameLabel.AutoSize = true;
            this.GameNameLabel.Location = new System.Drawing.Point(93, 100);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(69, 13);
            this.GameNameLabel.TabIndex = 1;
            this.GameNameLabel.Text = "Game Name:";
            // 
            // GameNameText
            // 
            this.GameNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameNameText.Location = new System.Drawing.Point(196, 97);
            this.GameNameText.Name = "GameNameText";
            this.GameNameText.Size = new System.Drawing.Size(349, 20);
            this.GameNameText.TabIndex = 2;
            // 
            // GameRatingLabel
            // 
            this.GameRatingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameRatingLabel.AutoSize = true;
            this.GameRatingLabel.Location = new System.Drawing.Point(89, 314);
            this.GameRatingLabel.Name = "GameRatingLabel";
            this.GameRatingLabel.Size = new System.Drawing.Size(77, 13);
            this.GameRatingLabel.TabIndex = 3;
            this.GameRatingLabel.Text = "Games Rating:";
            // 
            // GameHardwareLabel
            // 
            this.GameHardwareLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameHardwareLabel.AutoSize = true;
            this.GameHardwareLabel.Location = new System.Drawing.Point(84, 529);
            this.GameHardwareLabel.Name = "GameHardwareLabel";
            this.GameHardwareLabel.Size = new System.Drawing.Size(87, 13);
            this.GameHardwareLabel.TabIndex = 4;
            this.GameHardwareLabel.Text = "Game Hardware:";
            // 
            // GameHardwareDropdown
            // 
            this.GameHardwareDropdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameHardwareDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameHardwareDropdown.FormattingEnabled = true;
            this.GameHardwareDropdown.Items.AddRange(new object[] {
            "Microsoft Xbox One X",
            "Sony Playstation PS4 Pro"});
            this.GameHardwareDropdown.Location = new System.Drawing.Point(274, 525);
            this.GameHardwareDropdown.Name = "GameHardwareDropdown";
            this.GameHardwareDropdown.Size = new System.Drawing.Size(192, 21);
            this.GameHardwareDropdown.TabIndex = 5;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitButton.Location = new System.Drawing.Point(965, 722);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // GameRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 757);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.SubmitButton);
            this.Name = "GameRegistration";
            this.Text = "GameRegistration";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label GameNameLabel;
        private System.Windows.Forms.TextBox GameNameText;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label GameRatingLabel;
        private System.Windows.Forms.Label GameHardwareLabel;
        private System.Windows.Forms.ComboBox AgeRatingDropdown;
        private System.Windows.Forms.ComboBox GameHardwareDropdown;
    }
}