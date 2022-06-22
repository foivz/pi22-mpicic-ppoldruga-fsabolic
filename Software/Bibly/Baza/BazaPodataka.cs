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
        private SqlConnection Veza { get; set; }

        private static BazaPodataka instanca;
        public static BazaPodataka Instanca
        {
            get
            {
                if (instanca == null)
                    instanca = new BazaPodataka();
                return instanca;
            }
        }
        private BazaPodataka()
        {
        
        }

        public void UspostaviVezu()
        {
            Veza = new SqlConnection(connectionString);
            Veza.Open();
        }

        public void PrekiniVezu()
        {
            if (Veza.State != ConnectionState.Closed)
            {
                Veza.Close();
            }
        }
        public IDataReader DohvatiDataReader(string upit)
        {
            SqlCommand sqlCommand = new SqlCommand(upit, Veza);
            return sqlCommand.ExecuteReader();
        }
        public object DohvatiVrijednost(string upit)
        {
            SqlCommand sqlCommand = new SqlCommand(upit, Veza);
            return sqlCommand.ExecuteScalar();
        }
        public int IzvrsiNaredbu(string upit)
        {
            SqlCommand sqlCommand = new SqlCommand(upit, Veza);
            return sqlCommand.ExecuteNonQuery();
        }
    }
}
