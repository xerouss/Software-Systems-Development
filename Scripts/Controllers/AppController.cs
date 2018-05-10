using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Café_Demonstration_Program
{
    public class AppController
    {
        //protected View m_view;
        protected AppController m_nextController, m_prevController;

        public AppController(AppController prevController)
        {
            m_prevController = prevController;
        }

        public virtual void LoadView()
        {

        }
    }
}
