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
            SqlCommand cmd = MakeConnection("sp_insertIntoHardware");

            string[] data = newData.Split('\n');

            // Set the data to be added to the database
            cmd.Parameters.AddWithValue("@HardwareType", SqlDbType.VarChar).Value = data[0];
            cmd.Parameters.AddWithValue("@Peripheral", SqlDbType.VarChar).Value = data[1];

            // Carry out the SQL command
            int i = cmd.ExecuteNonQuery();

            // Close the database since we have finished using it
            con.Close();
        }


        public override string GetData()
        {
            SqlCommand cmd = MakeConnection("sp_selectHardware");

            reader = cmd.ExecuteReader();

            string hardware = "";

            while (reader.Read())
            {
                hardware += reader["HardwareType"].ToString() + "\n";
                hardware += reader["Peripheral"].ToString() + "\n";
            }

            // Close the database since we have finished using it
            con.Close();
            return hardware;
        }

    }
}
