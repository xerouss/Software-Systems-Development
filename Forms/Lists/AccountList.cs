using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Café_Demonstration_Program.Forms.Lists
{
    public partial class AccountList : View
    {
        const int numOfDataFields = 5;

        DataController m_dataController;

        public AccountList(DataController controller)
        {
            InitializeComponent();
            m_dataController = controller;
        }

        private void AccountList_Load(object sender, EventArgs e)
        {
            // Get the hardware data from the database
            RecieveData(m_dataController.GetData());

            // Get split the data string in order to get the value to display
            string[] dataSplit = m_data.Split('\n');
            string name = "";
            string username = "";
            string age = "";
            string membershipType = "";
            int modNum;

            for (int i = 0; i < dataSplit.Length; i++)
            {
                modNum = i % numOfDataFields;

                switch (modNum)
                {
                    case 0:
                        name += dataSplit[i] + '\n';
                        break;
                    case 1:
                        username += dataSplit[i] + '\n';
                        break;
                    // Don't do anything with case 2 because we don't want to display the account passwords
                    case 3:
                        age += dataSplit[i] + '\n';
                        break;
                    case 4:
                        membershipType += dataSplit[i] + '\n';
                        break;
                    default:
                        break;
                }
            }

            // Set the label text to the correct string here
        }

        private void HardwareList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
