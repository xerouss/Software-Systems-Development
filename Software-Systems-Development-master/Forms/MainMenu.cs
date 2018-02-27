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
    public partial class HardwareRegistration : Form
    {
        public HardwareRegistration()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void HardwareButton_Click(object sender, EventArgs e)
        {
            // Create a hardware form to show while closing this form
            HardwareList hardwareList = new HardwareList();
            this.Hide();
            hardwareList.ShowDialog();
            this.Close();
        }
    }
}
