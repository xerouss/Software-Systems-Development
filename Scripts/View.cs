using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Café_Demonstration_Program
{
    public class View : Form
    {
        protected string m_data;

        public View(): base()
        {
            // Need this constructor for the design view to be displayed
        }

        public View(DataController dataController): base()
        {
            // Need this constructor for the design view to be displayed
        }


        public void LoadView()
        {
            // Display this form
            this.Show();
        }

        public void RecieveData(string dataRecieved)
        {
            m_data = dataRecieved;
        }

        public void OnFormClose()
        {
            // Close the application when the form is closed by pressing the cross button
            Application.Exit();
        }
    }
}