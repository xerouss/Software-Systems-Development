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
    public partial class RegistrationPage : View
    {
        AccountController m_controller;
        string m_username;
        string m_password;
        string m_DoB;
        string m_membershipType;
        string m_name;
        string m_surname;
        
        public RegistrationPage(AccountController accountController)
        {
            m_controller = accountController;
            InitializeComponent();
        }



        private void RegistrationPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            m_username = NameText.Text;
            
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            m_password = PasswordBox.Text;
        }


        private void Register_Click(object sender, EventArgs e)
        {
            if (m_username != null && m_password != null && m_DoB != null && m_name != null && m_surname != null)
            {
                m_controller.AddData(m_name + "\n" + m_surname + "\n" + m_username + "\n" + m_password + "\n" + m_DoB + "\n" + m_membershipType);
                Age.Value = 0;
                Membership.ResetText();
                FirstName.ResetText();
                Surname.ResetText();
                NameText.ResetText();
                PasswordBox.ResetText();
                m_controller.LoadView();
                
            }
        }

        private void Age_ValueChanged(object sender, EventArgs e)
        {
            m_DoB = Age.Value.ToString();
        }

        private void Membership_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_membershipType = Membership.Text;
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
            m_name = FirstName.Text;
        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {
            m_surname = Surname.Text;
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Age.Value = 0;
            Membership.ResetText();
            FirstName.ResetText();
            Surname.ResetText();
            NameText.ResetText();
            PasswordBox.ResetText();
            m_controller.LoadView();

        }


    }
}
