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
    public partial class HardwareRegistration : View
    {

        DataController m_dataController;

        public HardwareRegistration(DataController dataController)
        {
            InitializeComponent();
            m_dataController = dataController;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_dataController.GoToMainMenu();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Resources used to implement
            // https://stackoverflow.com/questions/10263094/executenonquery-connection-property-has-not-been-initialized
            // http://www.c-sharpcorner.com/UploadFile/009464/insert-data-into-database-in-window-form-using-C-Sharp/
            // https://stackoverflow.com/questions/42868370/stored-procedure-not-found
            // NOTE THE VALUES ARE NOT KEPT WHEN CLOSING THE APPLICATION
            // HOWEVER WILL WORK IF YOU RUN THE APPLICATION FROM BIN/DEBUG FOLDER

            // Get the data to save into the database
            string peripheral = "";
            string hardware = "";
            if(HardwareDropDown.SelectedItem != null) hardware = HardwareDropDown.SelectedItem.ToString();
            if(PeripheralDropDown.SelectedItem != null) peripheral = PeripheralDropDown.SelectedItem.ToString();

            if (hardware != "")
            {
                m_dataController.AddData(hardware + "\n" + peripheral);

                this.Hide();
                m_dataController.GoToMainMenu();
            }
        }
    }
}
