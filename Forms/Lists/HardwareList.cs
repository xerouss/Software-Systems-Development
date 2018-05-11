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
    public partial class HardwareList : DataView
    {
        const int numOfDataFields = 2;

        public HardwareList(DataController controller) :
                    base(controller)
        {
            InitializeComponent();
        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            ReturnToMainMenu();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Create the hardware registration form to show while hiding this form
            HardwareRegistration hardwareRegistration = new HardwareRegistration(m_dataController);
            this.Hide();
            hardwareRegistration.Show();
        }

        private void HardwareList_Load(object sender, EventArgs e)
        {
            // Get the data
            string[] dataSplit = LoadData(m_dataController);
            string hardware = "";
            string peripherals = "";

            for (int i = 0; i < dataSplit.Length; i++)
            {
                // Since there are only two different sets of data needed
                // Every odd index will be the hardware while the even index would be the peripherals
                if (i % numOfDataFields == 0) hardware += dataSplit[i] + '\n';
                else peripherals += dataSplit[i] + '\n';
            }

            // Display the data
            HardwareNamesData.Text = hardware;
            PeripheralData.Text = peripherals;
        }

        private void HardwareList_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnFormClose();
        }
    }
}
