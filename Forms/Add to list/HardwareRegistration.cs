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
            string hardware = HardwareDropDown.SelectedText;
            string peripheral = PeripheralDropDown.SelectedText;

            SqlConnection con = new SqlConnection(@"Server=localhost\SQLExpress;"
       + "Database=HardwareDatabase;");

            // SqlConnection con = new SqlConnection("Data Source=.\SQLEXPRESS;" +
            //    "AttachDbFilename=|DataDirectory|\Databases\HardwareDatabase.mdf;Integrated Security=True;User Instance=True");

            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;" +
            //        "User Instance=true;" +
            //        "Integrated Security=true;" +
            //        "AttachDbFilename=|DataDirectory|HardwareDatabase.mdf;");

            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Hardware", hardware);
            cmd.Parameters.AddWithValue("@Peripheral", peripheral);

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
