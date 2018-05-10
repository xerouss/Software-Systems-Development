using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Café_Demonstration_Program
{
    public partial class LoginPage : View
    {
        AccountController m_controller;

        public LoginPage(AccountController appController)
        {
            InitializeComponent();
            m_controller = appController;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Check the login details match with an account
            // If so go to main menu
            m_controller.CheckLoginDetails(GetUserName(), GetPassword());
        }

        public string GetUserName()
        {
            // Implement this
            return "";
        }

        public string GetPassword()
        {
            // Implement this
            return "";
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            m_controller.GoToRegister();
        }
    }
}
