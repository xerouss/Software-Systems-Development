using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Café_Demonstration_Program
{
    public class MainMenuController: AppController
    {
        MainMenu m_view;
        DataController dataController;

        public MainMenuController(AppController prevController) :
            base(prevController)
        {
            // Call AppController Constructor
            dataController = new DataController(this);
            m_view = new MainMenu(this);
        }

        public void GoToHardwareList()
        {
            HardwareList view = new HardwareList(dataController);
            HardwareModel model = new HardwareModel();
            dataController.SetView(view);
            dataController.SetModel(model);
            m_view.Hide();
            view.LoadView();
        }

        public void GoToGameList()
        {

        }

        public void GoToEventList()
        {

        }

        public void GoToAccountList()
        {

        }

        public void GoToLogin()
        {
            m_prevController.LoadView();
        }

        public override void LoadView()
        {
            m_view.LoadView();
        }
    }
}
