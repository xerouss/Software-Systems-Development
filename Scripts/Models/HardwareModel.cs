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
            MakeConnection("sp_insertIntoHardware");

            base.AddData(newData);
        }

        public override void SetCommandParameters(string[] data)
        {
            // Set the data to be added to the database
            m_sqlCommand.Parameters.AddWithValue("@HardwareType", SqlDbType.VarChar).Value = data[0];
            m_sqlCommand.Parameters.AddWithValue("@Peripheral", SqlDbType.VarChar).Value = data[1];
        }


        public override string GetData()
        {
            // Connect with the database
            MakeConnection("sp_selectHardware");

            return base.GetData();
        }

        public override void GetDataFromReader(ref string data)
        {
            // Get the data from the database
            data += m_dataReader["HardwareType"].ToString() + "\n";
            data += m_dataReader["Peripheral"].ToString() + "\n";
        }
    }
}
