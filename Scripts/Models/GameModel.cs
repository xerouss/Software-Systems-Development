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
            MakeConnection("sp_insertIntoGames");

            base.AddData(newData);
        }

        public override void SetCommandParameters(string[] data)
        {
            // Set the data to be added to the database
            m_sqlCommand.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = data[0];
            m_sqlCommand.Parameters.AddWithValue("@Console", SqlDbType.VarChar).Value = data[1];
            m_sqlCommand.Parameters.AddWithValue("@AgeRating", SqlDbType.Int).Value = Int32.Parse(data[2]);
            // Default values used for now
            m_sqlCommand.Parameters.AddWithValue("@SinglePlayer", SqlDbType.Bit).Value = 0;
            m_sqlCommand.Parameters.AddWithValue("@ChartRating", SqlDbType.Int).Value = 1;
            m_sqlCommand.Parameters.AddWithValue("@Available", SqlDbType.Bit).Value = 0;
        }

        public override string GetData()
        {
            // Connect with the database
            MakeConnection("sp_selectGames");

            return base.GetData();
        }

        public override void GetDataFromReader(ref string data)
        {
            // Get the data from the database
            data += m_dataReader["Name"].ToString() + "\n";
            data += m_dataReader["Console"].ToString() + "\n";
            data += m_dataReader["AgeRating"].ToString() + "\n";
            data += m_dataReader["SinglePlayer"].ToString() + "\n";
            data += m_dataReader["ChartRating"].ToString() + "\n";
            data += m_dataReader["Available"].ToString() + "\n";
        }
    }
}
