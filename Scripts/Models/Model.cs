using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Game_Café_Demonstration_Program
{
    
    public class Model
    {
        protected SqlDataReader m_dataReader;
        protected SqlConnection m_dataConnection;
        protected SqlCommand m_sqlCommand;

        public Model()
        {
            
        }

        public virtual string GetData()
        {
            // Carry out the command
            m_dataReader = m_sqlCommand.ExecuteReader();

            string data = "";

            // Go through the database and get the data
            while (m_dataReader.Read())
            {
                GetDataFromReader(ref data);
            }

            // Close the database since we have finished using it
            m_dataConnection.Close();
            return data;

        }

        public virtual void GetDataFromReader(ref string data)
        {
            // Implemented in child classes
        }

        public virtual void AddData(string newData)
        {
            // Split up the string so the data can be set to be added
            string[] data = newData.Split('\n');

            SetCommandParameters(data);

            // Carry out the SQL command
            int i = m_sqlCommand.ExecuteNonQuery();

            // Close the database since we have finished using it
            m_dataConnection.Close();
        }

        public virtual void SetCommandParameters(string[] data)
        {
            // Implemented in child classes
        }

        public void MakeConnection(string command)
        {
            //has to make sure the connection is established every time the data needs to be set/got, to ensure up-to-date data.
            m_dataConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Databases\GameCaféDatabase.mdf;Integrated Security=True;");
            m_sqlCommand = new SqlCommand(command, m_dataConnection)
            {
                CommandType = CommandType.StoredProcedure
            };

            // Open the connection to the database and execute the command
            m_dataConnection.Open();
        }


    }

    
}
