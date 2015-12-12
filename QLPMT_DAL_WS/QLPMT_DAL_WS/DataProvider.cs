using System;
using System.Data.OleDb;
using System.Data;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;

namespace QLHS2010
{
    public class DataProvider
    {
        protected static string _connectionString;

        protected SqlConnection connection;
        protected SqlDataAdapter adapter;
        protected SqlCommand command;


        public static string ConnectionString
        {
            get
            {
                return _connectionString;
            }
            set
            {
                _connectionString = value;
            }
        }

        public void connect()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["QLPMT"].ConnectionString;
            connection = new SqlConnection(ConnectionString);
            connection.Open();
        }

        public void disconnect()
        {
            connection.Close();
        }

        public IDataReader executeQuery(string sqlString)
        {
            command = new SqlCommand(sqlString, connection);
            return command.ExecuteReader();
        }

        //public DataTable executeQuery(string sqlString)
        //{
        //    DataSet ds = new DataSet();
        //    adapter = new OleDbDataAdapter(sqlString, connection);
        //    adapter.Fill(ds);
        //    return ds.Tables[0];
        //}
        
        public void executeNonQuery(string sqlString)
        {
            command = new SqlCommand(sqlString, connection);
            command.ExecuteNonQuery();
        }

        public object executeScalar(string sqlString)
        {
            command = new SqlCommand(sqlString, connection);
            return command.ExecuteScalar();
        }

        protected ArrayList ConvertDataSetToArrayList(DataSet dataset)
        {
            ArrayList arr = new ArrayList();
            DataTable dt = dataset.Tables[0];
            int i, n = dt.Rows.Count;
            for (i = 0; i < n; i++)
            {
                object obj = GetDataFromDataRow(dt, i);
                arr.Add(obj);

            }            
            return arr;
        }

        public virtual object GetDataFromDataRow(DataTable dt, int i)
        {
            return null;
        }
    }
}