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
    public partial class MainMenu : View
    {
        MainMenuController m_controller;

        public MainMenu(MainMenuController mainController)
        {
            InitializeComponent();
            m_controller = mainController;
        }

        private void HardwareButton_Click(object sender, EventArgs e)
        {
            m_controller.GoToHardwareList();

            // Create a hardware form to show while closing this form
            //HardwareList hardwareList = new HardwareList();
            //this.Hide();
            //hardwareList.ShowDialog();
        }

        private void GamesButton_Click(object sender, EventArgs e)
        {
            m_controller.GoToGameList();

            
        }

        private void EventsButton_Click(object sender, EventArgs e)
        {
            m_controller.GoToEventList();

            
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
