namespace Game_Café_Demonstration_Program
{
    partial class GamesList
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
            this.RegisterGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // RegisterGameButton
            // 
            this.RegisterGameButton.Location = new System.Drawing.Point(12, 572);
            this.RegisterGameButton.Name = "RegisterGameButton";
            this.RegisterGameButton.Size = new System.Drawing.Size(122, 23);
            this.RegisterGameButton.TabIndex = 1;
            this.RegisterGameButton.Text = "Register New Game";
            this.RegisterGameButton.UseVisualStyleBackColor = true;
            this.RegisterGameButton.Click += new System.EventHandler(this.RegisterGameButton_Click);
            // 
            // GamesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 607);
            this.Controls.Add(this.RegisterGameButton);
            this.Controls.Add(this.Back);
            this.Name = "GamesList";
            this.Text = "GamesList";
            this.Load += new System.EventHandler(this.GamesList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button RegisterGameButton;
    }
}