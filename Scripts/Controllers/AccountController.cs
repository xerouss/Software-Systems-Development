using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Café_Demonstration_Program
{
    public class AccountController: AppController
    {
        LoginPage m_view;

        public AccountController(AppController prevController):
            base(prevController)
        {
            // Call AppController constructor

            m_nextController = new MainMenuController(this);
            m_view = new LoginPage(this);
            Application.Run(m_view);
        }

        public void CheckLoginDetails(string username, string password)
        {
            // Check details match an account here

            GoToMainMenu();
        }

        void GoToMainMenu()
        {
            m_view.Hide();
            m_nextController.LoadView();
        }

        public override void LoadView()
        {
            m_view.LoadView();
        }
    }
}
