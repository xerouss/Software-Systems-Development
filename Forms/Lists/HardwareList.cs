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
        DataController dataController;
        public HardwareList(DataController controller)
        {

            InitializeComponent();
            dataController = controller;
        }



        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            // Create a hardware form to show while closing this form
            //MainMenu mainMenu = new MainMenu();
            this.Hide();
            dataController.GoToMainMenu();

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Create the hardware registration form to show while closing this form
            HardwareRegistration hardwareRegistration = new HardwareRegistration(dataController);
            this.Hide();
            hardwareRegistration.Show();
        }

        private void HardwareList_Load(object sender, EventArgs e)
        {
            RecieveData(dataController.GetData());

            string[] dataSplit = data.Split('\n');
            string hardware = "";
            string peripherals = "";

            for (int i = 0; i < dataSplit.Length; i++)
            {
                if (i % 2 == 0) hardware += dataSplit[i] + '\n';
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
