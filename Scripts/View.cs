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
        AppController controller;

        protected string m_data;
        public void SetController(AppController setcontroller)
        {
            this.controller = setcontroller;
        }

        public void LoadView()
        {
            this.Show();
        }

        public void RecieveData(string dataRecieved)
        {
            m_data = dataRecieved;
        }
    }
}