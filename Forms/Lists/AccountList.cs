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
    public partial class AccountList : DataView
    {
        const int numOfDataFields = 6;

        public AccountList(DataController controller) :
            base(controller)
        {
            InitializeComponent();
        }

        private void AccountList_Load(object sender, EventArgs e)
        {
            // Get the data
            string[] dataSplit = LoadData(m_dataController);
            string name = "";
            string username = "";
            string age = "";
            string membershipType = "";
            int modNum;

            // Based on what the mod number is decides what the data it represents
            for (int i = 0; i < dataSplit.Length; i++)
            {
                modNum = i % numOfDataFields;

                switch (modNum)
                {
                    case 0:
                        name += dataSplit[i] + ' ';
                        break;
                    case 1:
                        name += dataSplit[i] + '\n';
                        break;
                    case 2:
                        username += dataSplit[i] + '\n';
                        break;
                    // Don't do anything with case 2 because we don't want to display the account passwords
                    case 4:
                        age += dataSplit[i] + '\n';
                        break;
                    case 5:
                        membershipType += dataSplit[i] + '\n';
                        break;
                    default:
                        break;
                }
            }

            // Display the data
            GameNamesData.Text = name;
            UsernameData.Text = username;
            AgeData.Text = age;
            MembershipData.Text = membershipType;
        }

        private void HardwareList_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnFormClose();
        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            ReturnToMainMenu();
        }
    }
}
