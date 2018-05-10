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
    public partial class GameRegistration : Form
    {

        DataController m_dataController;
        public GameRegistration(DataController dataController)
        {
            InitializeComponent();
            m_dataController = dataController;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_dataController.GoToMainMenu();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string gameName = "";
            string gameSystem = "";
            string gameRating = "";

            if (GameNameText.Text != null) gameName = GameNameText.Text.ToString();
            if (AgeRatingDropdown.SelectedItem != null) gameRating = AgeRatingDropdown.SelectedItem.ToString();
            if (GameHardwareDropdown.SelectedItem != null) gameSystem = GameHardwareDropdown.SelectedItem.ToString();

            if (gameName != "")
            {
                m_dataController.AddData(gameName + "\n" + gameSystem + "\n" + gameRating);
            }

            this.Hide();
            m_dataController.GoToMainMenu();
        }

        private void GameRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
