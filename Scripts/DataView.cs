using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Café_Demonstration_Program
{
    public class DataView: View
    {
        protected DataController m_dataController;

        public DataView(): base()
        {
            // Need empty constructor for the design view to be displayed
        }

        public DataView(DataController dataController): base(dataController)
        {
            m_dataController = dataController;
        }

        public string[] LoadData(DataController dataController)
        {
            // Get the data from the database
            RecieveData(dataController.GetData());

            // Get split the data string in order to get the value to display
            return m_data.Split('\n');
        }

        public void ReturnToMainMenu()
        {
            this.Hide(); // Stop displaying the current form
            m_dataController.GoToMainMenu(); // Show the main menu
        }
    }
}
