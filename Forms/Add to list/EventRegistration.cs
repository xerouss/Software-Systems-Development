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
    public partial class EventRegistration : DataView
    {
        public EventRegistration(DataController dataController)
            :base(dataController)
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ReturnToMainMenu();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Get the data from the fields that the user can input int
            // Automatically get the values of the fields that don't start blank
            string name = "";
            string game = "";
            string date = monthCalendar1.SelectionRange.Start.ToShortDateString();
            string time = "";
            string teams = Teams.Value.ToString();
            string members = NumOfMembers.Value.ToString();

            // If the field can be blank check that there is a value in it before retrieving it
            if (NameText.Text != null) name = NameText.Text;
            if (GameDropdown.SelectedItem != null) game = GameDropdown.SelectedItem.ToString();
            if (TimeValue.SelectedItem != null) time = TimeValue.SelectedItem.ToString();

            // If the values are not blank add the data to the database
            if(name != "" || game != "" || time != "")
            {
                m_dataController.AddData(name + "\n" + game + "\n" + date + "\n" + time + "\n" + teams + "\n" + members);
            }

            ReturnToMainMenu();
        }

        private void EventRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnFormClose();
        }
    }
}
