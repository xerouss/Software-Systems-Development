using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Café_Demonstration_Program
{
    public class DataController: AppController
    {
        View m_view;
        Model m_model;

        public DataController(AppController prevController) :
            base(prevController)
        {
            // Call AppController Constructor

            
        }

        public void SetView(View view)
        {
            m_view = view;
        }

        public void SetModel(Model model)
        {
            m_model = model;
        }

        public override void LoadView()
        {
            m_view.LoadView();
        }

        public string GetData()
        {
            return m_model.GetData();
        }

        public void AddData(string data)
        {
            m_model.AddData(data);
        }

        public virtual void GoToMainMenu()
        {
            m_view.Hide();
            m_prevController.LoadView();
        }
    }
}
