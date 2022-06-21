using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Baza
{
    public class BazaPodataka
    {
        private string connectionString = @"Data Source = 31.147.204.119\PISERVER,1433;Initial Catalog =PI2237_DB;User =PI2237_User;Password =3z@LEwQV";
        private SqlConnection Connection { get; set; }

        private static BazaPodataka instance;
        public static BazaPodataka Instance
        {
            get
            {
                if (instance == null)
                    instance = new BazaPodataka();
                return instance;
            }
        }
        private BazaPodataka()
        {
        
        }

        public void Connect()
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }

        public void Disconnect()
        {
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
        }
        public IDataReader GetReader(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query, Connection);
            return sqlCommand.ExecuteReader();
        }
        public object GetValue(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query, Connection);
            return sqlCommand.ExecuteScalar();
        }
        public int ExecuteCommand(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query, Connection);
            return sqlCommand.ExecuteNonQuery();
        }
    }
}
