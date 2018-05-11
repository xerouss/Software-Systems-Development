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
    public partial class EventList : DataView
    {
        const int numOfDataFields = 7;

        public EventList(DataController dataController):
            base (dataController)
        {
            InitializeComponent();
        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            ReturnToMainMenu();
        }

        private void EventList_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnFormClose();
        }

        private void EventList_Load(object sender, EventArgs e)
        {
            // Get the data
            string[] dataSplit = LoadData(m_dataController);
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

            // Display the data
            NamesData.Text = name;
            DateData.Text = date;
            TimeData.Text = time;
            TeamData.Text = teams;
            NumTeamMemberData.Text = teamMembers;
            GameData.Text = game;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            // Hide this form and show the event registration form
            EventRegistration eventRegistration = new EventRegistration(m_dataController);
            this.Hide();
            eventRegistration.Show();
        }

        private void RegisterTeamButton_Click(object sender, EventArgs e)
        {
           // Hide this form and show the team booking form
           TeamBooking teamBooking= new TeamBooking(m_dataController);
           this.Hide();
           teamBooking.Show();
        }
    }
}
