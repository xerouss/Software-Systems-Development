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
            cmd.Parameters.AddWithValue("@Name", SqlDbType.VarChar).Value = data[0];
            cmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = data[1];
            cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = data[2];
            cmd.Parameters.AddWithValue("@Age", SqlDbType.VarChar).Value = data[3];
            cmd.Parameters.AddWithValue("@MembershipType", SqlDbType.VarChar).Value = data[4];

            // Carry out the SQL command
            int i = cmd.ExecuteNonQuery();

            // Close the database since we have finished using it
            con.Close();
        }


        public override string GetData()
        {
            // Connect with the database
            SqlCommand cmd = MakeConnection("sp_selectAccounts");

            // Carry out the command
            reader = cmd.ExecuteReader();

            string accountData = "";

            // Go through the database and get the data
            while (reader.Read())
            {
                accountData += reader["Name"].ToString() + "\n";
                accountData += reader["Username"].ToString() + "\n";
                accountData += reader["Password"].ToString() + "\n";
                accountData += reader["Age"].ToString() + "\n";
                accountData += reader["MembershipType"].ToString() + "\n";
            }

            // Close the database since we have finished using it
            con.Close();
            return accountData;
        }
    }
}
