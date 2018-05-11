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
        DataController m_dataController;
        HardwareList m_hardwareListView;
        HardwareModel m_hardwareModel;
        GamesList m_gameList;
        GameModel m_gameModel;
        AccountModel m_accountModel;
        AccountList m_accountList;
        EventList m_eventList;
        EventModel m_eventModel;

        public MainMenuController(AppController prevController) :
            base(prevController)
        {
            // Call AppController Constructor

            m_dataController = new DataController(this);
            m_view = new MainMenu(this);
            m_hardwareListView = new HardwareList(m_dataController);
            m_hardwareModel = new HardwareModel();
            m_gameList = new GamesList(m_dataController);
            m_gameModel = new GameModel();
            m_accountModel = new AccountModel();
            m_accountList = new AccountList(m_dataController);
            m_eventModel = new EventModel();
            m_eventList = new EventList(m_dataController);
        }

        public void GoToHardwareList()
        {
            // Set the hardware list view/model and go to it
            GoToNewDataView(m_hardwareListView, m_hardwareModel);
        }

        public void GoToGameList()
        {
            GoToNewDataView(m_gameList, m_gameModel);
        }

        public void GoToEventList()
        {
            GoToNewDataView(m_eventList, m_eventModel);
        }

        public void GoToAccountList()
        {
            GoToNewDataView(m_accountList, m_accountModel);
        }

        void GoToNewDataView(View view, Model model)
        {
            // Set the view and model to the controller
            // Hide the main menu and go to the view
            m_dataController.SetView(view);
            m_dataController.SetModel(model);
            m_view.Hide();
            view.LoadView();
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
