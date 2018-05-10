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
    public partial class EventRegistration : View
    {
        DataController m_dataController;

        public EventRegistration(DataController dataController)
        {
            InitializeComponent();
            m_dataController = dataController;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_dataController.GoToMainMenu();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string name = "";
            string game = "";
            string date = monthCalendar1.SelectionRange.Start.ToShortDateString();
            string time = "";
            string teams = Teams.Value.ToString();
            string members = NumOfMembers.Value.ToString();

            if (NameText.Text != null) name = NameText.Text;
            if (GameDropdown.SelectedItem != null) game = GameDropdown.SelectedItem.ToString();
            if (TimeValue.SelectedItem != null) time = TimeValue.SelectedItem.ToString();

            if(name != "" || game != "" || time != "")
            {
                m_dataController.AddData(name + "\n" + game + "\n" + date + "\n" + time + "\n" + teams + "\n" + members);
            }

            this.Hide();
            m_dataController.GoToMainMenu();
        }
    }
}
