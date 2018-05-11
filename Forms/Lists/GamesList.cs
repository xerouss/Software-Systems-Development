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
    public partial class GamesList : DataView
    {
        const int numOfDataFields = 6;

        public GamesList(DataController dataController):
                  base(dataController)
        {
            InitializeComponent();
        }

        private void GamesList_Load(object sender, EventArgs e)
        {
            // Get the data
            string[] dataSplit = LoadData(m_dataController);
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

            // Display the information
            GameNamesData.Text = name;
            ConsoleData.Text = console;
            AgeRatingData.Text = age;
            SinglePlayerData.Text = singlePlayer;
            ChartData.Text = chartRating;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Hide this form and show the game registration form
            GameRegistration gameRegistration = new GameRegistration(m_dataController);
            this.Hide();
            gameRegistration.Show();
        }

        private void GameList_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnFormClose();
        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            ReturnToMainMenu();
        }
    }
}
