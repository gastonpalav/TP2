using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Data.Database
{
    public class Adapter
    {
        private const string consKeyDefaultCnnString = "ConnStringLocal";

        private SqlConnection sqlConn;

        public SqlConnection SqlConn
        {
            get { return sqlConn; }
        }

        protected void OpenConnection()
        {
            string con = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            sqlConn = new SqlConnection(con);
            sqlConn.Open();
        }

        protected void CloseConnection()
        {
            this.SqlConn.Close();
            sqlConn = null;
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}