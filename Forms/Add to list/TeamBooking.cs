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
    public partial class TeamBooking : DataView
    {
        const int numOfDataFieldsEvents = 7;
        const int numOfDataFieldsTeam = 2;
        const int nameFieldIndex = 0;
        const int makeBase1 = 1;
        const int numOfTeamsIndex = 4;

        DataController m_eventController;
        DataController m_teamController;
        TeamModel m_teamModel;
        int[] m_eventIds;
        int[] m_eventNumOfTeams;
        int m_teamsSignedUpForEvent = 0;

        public TeamBooking(DataController dataController)
        {
            m_dataController = dataController;
            InitializeComponent();
            m_eventController = dataController;
            m_teamController = new DataController(null);
            m_teamModel = new TeamModel();
            m_teamController.SetModel(m_teamModel);
        }

        private void EventDropDown_VisibleChanged(object sender, EventArgs e)
        {
            // Get rid of the current options in the drop down
            EventDropDown.Items.Clear();

            // Get the event data to get all the names of the current events
            string[] dataSplit = LoadData(m_eventController);
            string eventNames = "";
            string numOfTeams = "";

            for (int i = 0; i < dataSplit.Length; i++)
            {
                // Mod the index by the total amount of data fields there are
                // So it can loop round and collect all the data
                if (i % numOfDataFieldsEvents == nameFieldIndex) eventNames += dataSplit[i] + '\n';
                else if (i % numOfDataFieldsEvents == numOfTeamsIndex) numOfTeams += dataSplit[i] + '\n';
            }

            // Split up the names since all names have been retrieved
            string[] eventNamesSplit = eventNames.Split('\n');
            string[] numOfTeamsSplit = numOfTeams.Split('\n');

            // Create the array to store the IDS for the event
            m_eventIds = new int[eventNames.Length];
            m_eventNumOfTeams = new int[numOfTeamsSplit.Length];

            // For each name add a new option and save the Id of the option
            for (int i = 0; i < eventNamesSplit.Length; i++)
            {
                if (eventNamesSplit[i] == "") continue;

                m_eventIds[i] = i;
                EventDropDown.Items.Add(eventNamesSplit[i]);
                if (numOfTeamsSplit[i] != "") m_eventNumOfTeams[i] = Int32.Parse(numOfTeamsSplit[i]);
            }
        }

        private void CancelRegistrationButton_Click(object sender, EventArgs e)
        {
            ReturnToMainMenu();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string name = "";
            string eventID = "";

            // Check if the fields are blank then get the values
            if (NameText.Text != null) name = NameText.Text;
            // +1 the event ID because it starts at 1
            if (EventDropDown.SelectedItem != null) eventID = m_eventIds[EventDropDown.SelectedIndex].ToString() + makeBase1;

            // Check if they have values, if so add them to the database
            if (name != "" && eventID != "")
            {
                if (m_teamsSignedUpForEvent < m_eventNumOfTeams[EventDropDown.SelectedIndex])
                {
                    m_teamController.AddData(name + "\n" + eventID);
                }
            }

            // Go back to the main menu
            this.Hide();
            m_eventController.GoToMainMenu();
        }

        private void EventDropDown_TextChanged(object sender, EventArgs e)
        {
            m_teamsSignedUpForEvent = 0;

            ListOfTeams.Text = "Current Teams: \n";

            // Get the data and split up the data
            string[] dataSplit = LoadData(m_teamController);

            List<string> teamNames = new List<string>();
            List<string> id = new List<string>();
            int modNum = 0;

            // Go through the data and split them up into different arrays
            for (int i = 0; i < dataSplit.Length; i++)
            {
                modNum = i % numOfDataFieldsTeam;
                if (modNum == nameFieldIndex) teamNames.Add(dataSplit[i] + '\n');
                else id.Add(dataSplit[i]);
            }

            // If the event is selected, display the teams for it
            for (int i = 0; i < id.Count; i++)
            {
                // Need to +1 the selected index because its base 0 while the database saves as base 1
                if (id[i] == (EventDropDown.SelectedIndex + makeBase1).ToString())
                {
                    ListOfTeams.Text += teamNames[i];
                    m_teamsSignedUpForEvent++;
                }
            }
        }

        private void TeamBooking_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnFormClose();
        }
    }
}
