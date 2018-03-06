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
        public HardwareRegistration()
        {
            InitializeComponent();
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
            // https://stackoverflow.com/questions/10263094/executenonquery-connection-property-has-not-been-initialized
            // http://www.c-sharpcorner.com/UploadFile/009464/insert-data-into-database-in-window-form-using-C-Sharp/

            // NEED TO CREATE A PROCEDURE FROM THIS FOR IT TO WORK
            // CANNOT DO IT AT UNI BECAUSE I THINK ITS BLOCKING ACCESS
            // NEED TO CHANGE THE HARDWARE AND PERIPHERAL VALUES TO VARCHAR
            // AND CHANGE HARDWARE FIELD TO HARDWARE TYPE
            // USE ONE DATABASE AS WELL INSTEAD OF MULTIPLE FOR EVERYTHING AND JUST DO NEW TABLES
            //https://stackoverflow.com/questions/42868370/stored-procedure-not-found

            string hardware = HardwareDropDown.SelectedItem.ToString();
            string peripheral = PeripheralDropDown.SelectedItem.ToString();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Databases\HardwareRegistrationDatabase.mdf;Integrated Security=True;");

            // SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Hardware] ([Id], [Hardware], [Peripheral])" +
            //    "VALUES (@ID, @Hardware, @Peripheral);");
            SqlCommand cmd = new SqlCommand("sp_insert", con);

            //cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = 0;
            cmd.Parameters.AddWithValue("@Hardware", SqlDbType.VarChar).Value = hardware;
            cmd.Parameters.AddWithValue("@Peripheral", SqlDbType.VarChar).Value = peripheral;

            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            ReturnBackToHardwareList();
        }

        void ReturnBackToHardwareList()
        {
            // Returns back to the hardware list
            HardwareList mainMenu = new HardwareList();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }
    }
}
