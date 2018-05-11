using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Game_Café_Demonstration_Program
{
    public class AccountModel : Model
    {
        public override void AddData(string newData)
        {
            // Connect with the database
            MakeConnection("sp_insertIntoAccount");

            base.AddData(newData);
        }

        public override void SetCommandParameters(string[] data)
        {
            // Set the data to be added to the database
            m_sqlCommand.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = data[0];
            m_sqlCommand.Parameters.AddWithValue("@Surname", SqlDbType.VarChar).Value = data[1];
            m_sqlCommand.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = data[2];
            m_sqlCommand.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = data[3];
            m_sqlCommand.Parameters.AddWithValue("@Age", SqlDbType.Int).Value = Int32.Parse(data[4]);
            m_sqlCommand.Parameters.AddWithValue("@MembershipType", SqlDbType.VarChar).Value = data[5];
        }


        public override string GetData()
        {
            // Connect with the database
            MakeConnection("sp_selectAccounts");

            return base.GetData();
        }

        public override void GetDataFromReader(ref string data)
        {
            // Get the data from the database
            data += m_dataReader["FirstName"].ToString() + "\n";
            data += m_dataReader["Surname"].ToString() + "\n";
            data += m_dataReader["Username"].ToString() + "\n";
            data += m_dataReader["Password"].ToString() + "\n";
            data += m_dataReader["Age"].ToString() + "\n";
            data += m_dataReader["MembershipType"].ToString() + "\n";
        }
    }
}
