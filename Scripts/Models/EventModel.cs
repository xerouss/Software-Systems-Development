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
            SqlCommand cmd = MakeConnection("sp_insertIntoEvent");

            // Split up the string so the data can be set to be added
            string[] data = newData.Split('\n');

            // Set the data to be added to the database
            cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = data[0];
            cmd.Parameters.AddWithValue("@Game", SqlDbType.VarChar).Value = data[1];
            cmd.Parameters.AddWithValue("@Date", SqlDbType.VarChar).Value = data[2];
            cmd.Parameters.AddWithValue("@Time", SqlDbType.VarChar).Value = data[3];
            cmd.Parameters.AddWithValue("@NumOfTeams", SqlDbType.Int).Value = Int32.Parse(data[4]);
            cmd.Parameters.AddWithValue("@NumOfTeamMembers", SqlDbType.Int).Value = Int32.Parse(data[5]);

            // Carry out the SQL command
            int i = cmd.ExecuteNonQuery();

            // Close the database since we have finished using it
            m_dataConnection.Close();
        }


        public override string GetData()
        {
            // Connect with the database
            SqlCommand cmd = MakeConnection("sp_selectEvent");

            // Carry out the command
            m_dataReader = cmd.ExecuteReader();

            string eventData = "";

            // Go through the database and get the data
            while (m_dataReader.Read())
            {
                eventData += m_dataReader["Name"].ToString() + "\n";
                eventData += m_dataReader["Date"].ToString() + "\n";
                eventData += m_dataReader["Time"].ToString() + "\n";
                eventData += m_dataReader["AvailableTickets"].ToString() + "\n";
                eventData += m_dataReader["NumOfTeams"].ToString() + "\n";
                eventData += m_dataReader["NumOfTeamMembers"].ToString() + "\n";
                eventData += m_dataReader["Game"].ToString() + "\n";
            }

            // Close the database since we have finished using it
            m_dataConnection.Close();
            return eventData;
        }
    }
}
