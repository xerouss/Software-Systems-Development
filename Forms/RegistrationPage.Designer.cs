namespace Game_Café_Demonstration_Program
{
    partial class RegistrationPage
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
            this.NameText = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Button();
            this.Age = new System.Windows.Forms.NumericUpDown();
            this.Membership = new System.Windows.Forms.ComboBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            this.SuspendLayout();
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(81, 95);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 0;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(81, 121);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(81, 261);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 5;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(81, 170);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(57, 20);
            this.Age.TabIndex = 7;
            this.Age.ValueChanged += new System.EventHandler(this.Age_ValueChanged);
            // 
            // Membership
            // 
            this.Membership.FormattingEnabled = true;
            this.Membership.Items.AddRange(new object[] {
            "Non-Memeber",
            "Bronze",
            "Silver",
            "Gold"});
            this.Membership.Location = new System.Drawing.Point(81, 207);
            this.Membership.Name = "Membership";
            this.Membership.Size = new System.Drawing.Size(121, 21);
            this.Membership.TabIndex = 8;
            this.Membership.SelectedIndexChanged += new System.EventHandler(this.Membership_SelectedIndexChanged);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(81, 43);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 20);
            this.FirstName.TabIndex = 9;
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(81, 69);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(100, 20);
            this.Surname.TabIndex = 10;
            this.Surname.TextChanged += new System.EventHandler(this.Surname_TextChanged);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(537, 43);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 11;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // RegistrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 527);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Membership);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.NameText);
            this.Name = "RegistrationPage";
            this.Text = "RegistrationPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.NumericUpDown Age;
        private System.Windows.Forms.ComboBox Membership;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Button Return;
    }
}