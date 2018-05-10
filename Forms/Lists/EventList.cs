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
    public partial class EventList : View
    {
        const int numOfDataFields = 7;
        DataController m_dataController;

        public EventList(DataController dataController)
        {
            InitializeComponent();
            m_dataController = dataController;
        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            // Go back to the main menu
            this.Hide();
            m_dataController.GoToMainMenu();
        }

        private void EventList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EventList_Load(object sender, EventArgs e)
        {
            RecieveData(m_dataController.GetData());

            // Get split the data string in order to get the value to display
            string[] dataSplit = m_data.Split('\n');
            string name = "";
            string date = "";
            string time = "";
            string tickets = "";
            string teams = "";
            string teamMembers = "";
            string game = "";
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
                        date += dataSplit[i] + '\n';
                        break;
                    case 2:
                        time += dataSplit[i] + '\n';
                        break;
                    case 3:
                        tickets += dataSplit[i] + '\n';
                        break;
                    case 4:
                        teams += dataSplit[i] + '\n';
                        break;
                    case 5:
                        teamMembers += dataSplit[i] + '\n';
                        break;
                    case 6:
                        game += dataSplit[i] + '\n';
                        break;
                    default:
                        break;
                }
            }

            NamesData.Text = name;
            DateData.Text = date;
            TimeData.Text = time;
            TeamData.Text = teams;
            NumTeamMemberData.Text = teamMembers;
            GameData.Text = game;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            EventRegistration eventRegistration = new EventRegistration(m_dataController);

            this.Hide();

            eventRegistration.Show();
        }

        private void RegisterTeamButton_Click(object sender, EventArgs e)
        {
           TeamBooking teamBooking= new TeamBooking(m_dataController);

           this.Hide();

           teamBooking.Show();
        }
    }
}
