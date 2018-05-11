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
    public partial class HardwareRegistration : DataView
    {

        public HardwareRegistration(DataController dataController):
            base(dataController)
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ReturnToMainMenu();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Get the data to save into the database
            string peripheral = "";
            string hardware = "";

            // Make sure the fields are not before getting the data to prevent errors
            if(HardwareDropDown.SelectedItem != null) hardware = HardwareDropDown.SelectedItem.ToString();
            if(PeripheralDropDown.SelectedItem != null) peripheral = PeripheralDropDown.SelectedItem.ToString();

            // Add the data if there is a hardware inputted
            if (hardware != "")
            {
                m_dataController.AddData(hardware + "\n" + peripheral);
            }

            ReturnToMainMenu();
        }

        private void HardwareRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnFormClose();
        }
    }
}
