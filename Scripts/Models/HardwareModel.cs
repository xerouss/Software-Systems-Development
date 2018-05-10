using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Game_Café_Demonstration_Program
{
    public class HardwareModel : Model
    {
        public override void AddData(string newData)
        {
            // Connect with the database
            SqlCommand cmd = MakeConnection("sp_insertIntoHardware");

            // Split up the string so the data can be set to be added
            string[] data = newData.Split('\n');

            // Set the data to be added to the database
            cmd.Parameters.AddWithValue("@HardwareType", SqlDbType.VarChar).Value = data[0];
            cmd.Parameters.AddWithValue("@Peripheral", SqlDbType.VarChar).Value = data[1];

            // Carry out the SQL command
            int i = cmd.ExecuteNonQuery();

            // Close the database since we have finished using it
            m_dataConnection.Close();
        }


        public override string GetData()
        {
            // Connect with the database
            SqlCommand cmd = MakeConnection("sp_selectHardware");

            // Carry out the command
            m_dataReader = cmd.ExecuteReader();

            string hardwareData = "";

            // Go through the database and get the data
            while (m_dataReader.Read())
            {
                hardwareData += m_dataReader["HardwareType"].ToString() + "\n";
                hardwareData += m_dataReader["Peripheral"].ToString() + "\n";
            }

            // Close the database since we have finished using it
            m_dataConnection.Close();
            return hardwareData;
        }

    }
}
