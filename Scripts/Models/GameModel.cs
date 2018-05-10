using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Game_Café_Demonstration_Program
{
    public class GameModel : Model
    {
        public override void AddData(string newData)
        {
            // Connect with the database
            SqlCommand cmd = MakeConnection("sp_insertIntoGames");

            // Split up the string so the data can be set to be added
            string[] data = newData.Split('\n');

            // Set the data to be added to the database
            cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = data[0];
            cmd.Parameters.AddWithValue("@Console", SqlDbType.VarChar).Value = data[1];
            cmd.Parameters.AddWithValue("@AgeRating", SqlDbType.Int).Value = Int32.Parse(data[2]);
            cmd.Parameters.AddWithValue("@SinglePlayer", SqlDbType.Bit).Value = 0;//data[3];
            cmd.Parameters.AddWithValue("@ChartRating", SqlDbType.Int).Value = 1;// data[4];
            cmd.Parameters.AddWithValue("@Available", SqlDbType.Bit).Value = 0;//  data[5];

            // Carry out the SQL command
            int i = cmd.ExecuteNonQuery();

            // Close the database since we have finished using it
            m_dataConnection.Close();
        }


        public override string GetData()
        {
            // Connect with the database
            SqlCommand cmd = MakeConnection("sp_selectGames");

            // Carry out the command
            m_dataReader = cmd.ExecuteReader();

            string gamesData = "";

            // Go through the database and get the data
            while (m_dataReader.Read())
            {
                gamesData += m_dataReader["Name"].ToString() + "\n";
                gamesData += m_dataReader["Console"].ToString() + "\n";
                gamesData += m_dataReader["AgeRating"].ToString() + "\n";
                gamesData += m_dataReader["SinglePlayer"].ToString() + "\n";
                gamesData += m_dataReader["ChartRating"].ToString() + "\n";
                gamesData += m_dataReader["Available"].ToString() + "\n";
            }

            // Close the database since we have finished using it
            m_dataConnection.Close();
            return gamesData;
        }
    }
}
