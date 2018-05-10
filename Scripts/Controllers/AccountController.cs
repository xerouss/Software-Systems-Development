using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Café_Demonstration_Program
{
    public class AccountController: DataController
    {
        LoginPage m_view;
        RegistrationPage m_registrationPage;
        AccountModel m_accountModel;
        


        public AccountController(AppController prevController):
            base(prevController)
        {
            // Call AppController constructor
            
            m_nextController = new MainMenuController(this);
            m_view = new LoginPage(this);
            m_registrationPage = new RegistrationPage(this);
            m_accountModel = new AccountModel();
            SetModel(m_accountModel);
            Application.Run(m_view);

        }

        public void CheckLoginDetails(string username, string password)
        {
            // Check details match an account here

            GoToMainMenu();
        }

        public override void GoToMainMenu()
        {
            m_view.Hide();
            m_nextController.LoadView();
        }

        public override void LoadView()
        {
            m_registrationPage.Hide();
            m_view.LoadView();
        }

        public void GoToRegister()
        {
            m_view.Hide();
            m_registrationPage.LoadView();
        }
    }
}
