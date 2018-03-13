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
    public partial class HardwareList : Form
    {
        public HardwareList()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            // Create a hardware form to show while closing this form
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Create the hardware registration form to show while closing this form
            HardwareRegistration mainMenu = new HardwareRegistration();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void HardwareList_Load(object sender, EventArgs e)
        {
            // Connect to the database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Databases\GameCaféDatabase.mdf;Integrated Security=True;");
            // Create the command which will be used to interact with the database
            SqlCommand cmd = new SqlCommand("sp_selectHardware", con);

            // Set the data which will be added to the database
            cmd.CommandType = CommandType.StoredProcedure;

            // Open the connection to the database and execute the command
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            string hardwareType = "";
            string peripheral = "";

            while (reader.Read())
            {
                hardwareType += reader["HardwareType"].ToString() + "\n";
                peripheral += reader["Peripheral"].ToString() + "\n";
            }

            // Close the database since we have finished using it
            con.Close();

            HardwareNamesData.Text = hardwareType;
            PeripheralData.Text = peripheral;
        }
    }
}
