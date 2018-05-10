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
    public partial class GamesList : View
    {
        const int numOfDataFields = 6;

        DataController m_dataController;

        public GamesList(DataController dataController)
        {
            InitializeComponent();
            m_dataController = dataController;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            // Go back to the main menu
            this.Hide();
            m_dataController.GoToMainMenu();
        }

        private void GamesList_Load(object sender, EventArgs e)
        {
            RecieveData(m_dataController.GetData());

            // Get split the data string in order to get the value to display
            string[] dataSplit = m_data.Split('\n');
            string name = "";
            string console = "";
            string age = "";
            string singlePlayer = "";
            string chartRating = "";
            string available = "";
            int modNum;

            for (int i = 0; i < dataSplit.Length; i++)
            {
                // Mod the index by the total amount of data fields there are
                // So it can loop round and collect all the data
                modNum = i % numOfDataFields;

                // Based on what the mod number is decides what the data it represents
                switch (modNum)
                {
                    case 0:
                        name += dataSplit[i] + '\n';
                        break;
                    case 1:
                        console += dataSplit[i] + '\n';
                        break;
                    case 2:
                        age += dataSplit[i] + '\n';
                        break;
                    case 3:
                        singlePlayer += dataSplit[i] + '\n';
                        break;
                    case 4:
                        chartRating += dataSplit[i] + '\n';
                        break;
                    case 5:
                        available += dataSplit[i] + '\n';
                        break;
                    default:
                        break;
                }
            }

            // Set the label text to the correct string here
        }

        private void RegisterGame_Click(object sender, EventArgs e)
        {
            GameRegistration gameRegistration = new GameRegistration(m_dataController);

            this.Hide();

            gameRegistration.Show();
        }
    }
}
