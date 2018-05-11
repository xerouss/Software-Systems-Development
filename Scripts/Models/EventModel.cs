using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Game_Café_Demonstration_Program
{
    public class EventModel : Model
    {
        public override void AddData(string newData)
        {
            // Connect with the database
            MakeConnection("sp_insertIntoEvent");

            base.AddData(newData);
        }

        public override void SetCommandParameters(string[] data)
        {
            // Set the data to be added to the database
            m_sqlCommand.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = data[0];
            m_sqlCommand.Parameters.AddWithValue("@Game", SqlDbType.VarChar).Value = data[1];
            m_sqlCommand.Parameters.AddWithValue("@Date", SqlDbType.VarChar).Value = data[2];
            m_sqlCommand.Parameters.AddWithValue("@Time", SqlDbType.VarChar).Value = data[3];
            m_sqlCommand.Parameters.AddWithValue("@NumOfTeams", SqlDbType.Int).Value = Int32.Parse(data[4]);
            m_sqlCommand.Parameters.AddWithValue("@NumOfTeamMembers", SqlDbType.Int).Value = Int32.Parse(data[5]);
        }

        public override string GetData()
        {
            // Connect with the database
            MakeConnection("sp_selectEvent");

            return base.GetData();
        }

        public override void GetDataFromReader(ref string data)
        {
            // Get the data from the database
            data += m_dataReader["Name"].ToString() + "\n";
            data += m_dataReader["Date"].ToString() + "\n";
            data += m_dataReader["Time"].ToString() + "\n";
            data += m_dataReader["AvailableTickets"].ToString() + "\n";
            data += m_dataReader["NumOfTeams"].ToString() + "\n";
            data += m_dataReader["NumOfTeamMembers"].ToString() + "\n";
            data += m_dataReader["Game"].ToString() + "\n";
        }
    }
}
