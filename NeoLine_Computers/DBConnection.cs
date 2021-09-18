using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoLine_Computers
{    
    class DBConnection
    {
        MySqlConnection conn;
        public DBConnection()
        {
            try
            {
                String myConnection = "server=localhost;User Id=root;Password=;Database=neoline_computers;SSL Mode=none";
                conn = new MySqlConnection(myConnection);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public MySqlConnection getConn()
        {
            return conn;
        }

       /* public MySqlDataReader ExecuteReader(string sql)
        {
            try
            {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }*/


    }
}
