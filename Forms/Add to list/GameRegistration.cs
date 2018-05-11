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
    public partial class GameRegistration : DataView
    {
        public GameRegistration(DataController dataController):
            base(dataController)
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ReturnToMainMenu();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string gameName = "";
            string gameSystem = "";
            string gameRating = "";

           // If the field can be blank check that there is a value in it before retrieving it
            if (GameNameText.Text != null) gameName = GameNameText.Text.ToString();
            if (AgeRatingDropdown.SelectedItem != null) gameRating = AgeRatingDropdown.SelectedItem.ToString();
            if (GameHardwareDropdown.SelectedItem != null) gameSystem = GameHardwareDropdown.SelectedItem.ToString();

            // If the values are not blank add the data to the database
            if (gameName != "")
            {
                m_dataController.AddData(gameName + "\n" + gameSystem + "\n" + gameRating);
            }

            ReturnToMainMenu();
        }

        private void GameRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnFormClose();
        }
    }
}
