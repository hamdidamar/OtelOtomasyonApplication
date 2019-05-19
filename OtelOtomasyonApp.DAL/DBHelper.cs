using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OtelOtomasyonApp.DAL
{
   public class DBHelper
    {
        private readonly string _connectionSting;

        public DBHelper()
        {
            _connectionSting = @"Data Source=DESKTOP-K2NN6MN\SQL_2014;Initial Catalog=OtelOtomasyonApp;Integrated Security=True";

        }

        private SqlConnection GetSqlConnection()
        {
            SqlConnection cnn = new SqlConnection(_connectionSting);
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Open();

            }
            else
            {
                cnn.Open();
            }
            return cnn;
        }

        public SqlCommand GetSqlCommand()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = GetSqlConnection();
            return cmd;
        }
    }
}
