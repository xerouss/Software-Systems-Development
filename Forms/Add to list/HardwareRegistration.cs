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
    public partial class HardwareRegistration : Form
    {

        DataController m_dataController;

        public HardwareRegistration(DataController dataController)
        {
            InitializeComponent();
            m_dataController = dataController;
        }

        private void HardwareRegistration_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ReturnBackToHardwareList();
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
                //// Connect to the database
                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Databases\GameCaféDatabase.mdf;Integrated Security=True;");
                //// Create the command which will be used to interact with the database
                //SqlCommand cmd = new SqlCommand("sp_insertIntoHardware", con);

                //// Set the data which will be added to the database
                //cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.AddWithValue("@HardwareType", SqlDbType.VarChar).Value = hardware;
                //cmd.Parameters.AddWithValue("@Peripheral", SqlDbType.VarChar).Value = peripheral;

                //// Open the connection to the database and execute the command
                //con.Open();
                //int i = cmd.ExecuteNonQuery();

                //// Close the database since we have finished using it
                //con.Close();

                //// Return the user back to the hardware list
                //ReturnBackToHardwareList();
                this.Hide();
                m_dataController.GoToMainMenu();
            }
        }

        void ReturnBackToHardwareList()
        {
            // Returns back to the hardware list
            //HardwareList mainMenu = new HardwareList();
            //this.Hide();
            //mainMenu.ShowDialog();
        }
    }
}
