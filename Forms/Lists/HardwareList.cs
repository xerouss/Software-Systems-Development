using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Game_Café_Demonstration_Program
{
    public partial class HardwareList : View
    {
        const int numOfDataFields = 2;

        DataController m_dataController;

        public HardwareList(DataController controller)
        {
            InitializeComponent();
            m_dataController = controller;
        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            // Go back to the main menu
            this.Hide();
            m_dataController.GoToMainMenu();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Create the hardware registration form to show while closing this form
            HardwareRegistration hardwareRegistration = new HardwareRegistration(m_dataController);
            this.Hide();
            hardwareRegistration.Show();
        }

        private void HardwareList_Load(object sender, EventArgs e)
        {
            // Get the hardware data from the database
            RecieveData(m_dataController.GetData());

            // Get split the data string in order to get the value to display
            string[] dataSplit = m_data.Split('\n');
            string hardware = "";
            string peripherals = "";

            for (int i = 0; i < dataSplit.Length; i++)
            {
                // Since there are only two different sets of data needed
                // Every odd index will be the hardware while the even index would be the peripherals
                if (i % numOfDataFields == 0) hardware += dataSplit[i] + '\n';
                else peripherals += dataSplit[i] + '\n';
            }

            HardwareNamesData.Text = hardware;
            PeripheralData.Text = peripherals;
        }

        private void HardwareList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
