using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Café_Demonstration_Program
{
    public class View
    {
        AppController controller;
        View(AppController appController)
        {

        }

        public void SetController(AppController setcontroller)
        {
            this.controller = setcontroller;
        }
    }
}
