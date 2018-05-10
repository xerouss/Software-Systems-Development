using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Game_Café_Demonstration_Program
{
    
    public class Model
    {
        protected SqlDataReader reader;
        protected SqlConnection con;

        public Model()
        {
            
        }

        public virtual string GetData()
        {

            return null;

        }

        public virtual void AddData(string newData)
        {

        }

        public SqlCommand MakeConnection(string command)
        {
            //has to make sure the connection is established every time the data needs to be set/got, to ensure up-to-date data.
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Databases\GameCaféDatabase.mdf;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand(command, con)
            {
                CommandType = CommandType.StoredProcedure
            };

            // Open the connection to the database and execute the command
            con.Open();

            return cmd;
        }


    }

    
}
