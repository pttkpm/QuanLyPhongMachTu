using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYPHONGMACHTU
{
    class DataProvider
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
            connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
            }
            catch(SqlException e)
            {
                MessageBox.Show("khong the ket noi database");
            }
        }

        public void disconnect()
        {
            connection.Close();
        }

        /*
        public IDataReader executeQuery(string sqlString)
        {

            command = new SqlCommand(sqlString, connection);
            return command.ExecuteReader();

        }
          */
            public DataTable executeQuery(string sqlString)
              {
                    DataSet ds = new DataSet();
                    adapter = new SqlDataAdapter(sqlString, connection);
                    adapter.Fill(ds);
                    return ds.Tables[0];
              }
        

        public void executeNonQuery(string sqlString)
        {
            command = new SqlCommand(sqlString, connection);

            try
            {
                command.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                MessageBox.Show("loi thuc thi");
            }
            
        }

        public object executeScalar(string sqlString)
        {
            command = new SqlCommand(sqlString, connection);
            return command.ExecuteScalar();
        }
    
    }
}
