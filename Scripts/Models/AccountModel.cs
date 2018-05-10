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
            SqlCommand cmd = MakeConnection("sp_insertIntoAccount");

            // Split up the string so the data can be set to be added
            string[] data = newData.Split('\n');

            // Set the data to be added to the database
            cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = data[0];
            cmd.Parameters.AddWithValue("@Surname", SqlDbType.VarChar).Value = data[1];
            cmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = data[2];
            cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = data[3];
            cmd.Parameters.AddWithValue("@Age", SqlDbType.Int).Value = Int32.Parse (data[4]);
            cmd.Parameters.AddWithValue("@MembershipType", SqlDbType.VarChar).Value = data[5];

            // Carry out the SQL command
            int i = cmd.ExecuteNonQuery();

            // Close the database since we have finished using it
            m_dataConnection.Close();
        }


        public override string GetData()
        {
            // Connect with the database
            SqlCommand cmd = MakeConnection("sp_selectAccounts");

            // Carry out the command
            m_dataReader = cmd.ExecuteReader();

            string accountData = "";

            // Go through the database and get the data
            while (m_dataReader.Read())
            {
                accountData += m_dataReader["Name"].ToString() + "\n";
                accountData += m_dataReader["Username"].ToString() + "\n";
                accountData += m_dataReader["Password"].ToString() + "\n";
                accountData += m_dataReader["Age"].ToString() + "\n";
                accountData += m_dataReader["MembershipType"].ToString() + "\n";
            }

            // Close the database since we have finished using it
            m_dataConnection.Close();
            return accountData;
        }
    }
}
