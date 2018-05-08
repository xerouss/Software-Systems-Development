using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Café_Demonstration_Program
{
    public class AppController
    {
        View m_View;
        AppController nextController, prevController;
        AppController(AppController plevController, View view, Model model)

        {
            view.SetController(this);
        }

        public void LoadView(View view)
        {
            
        }

    }
}
