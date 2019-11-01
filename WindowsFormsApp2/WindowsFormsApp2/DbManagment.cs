using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erp
{
    public class DbManagment
    {
        static string connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=erp; Integrated Security=True;";



        public static void SqlCommandRun(SqlCommand sqlCmd)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                sqlCmd.Connection = sqlCon;
                sqlCmd.ExecuteNonQuery();
            }
        }
        public static DataTable SqlDataAdRun(string query)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlData = new SqlDataAdapter(query, sqlCon);
                sqlCon.Open();

                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                return dtbl;

            }
        }
        public static DataSet SqlDataSetCreate(string query, string tablename)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlData = new SqlDataAdapter(query, sqlCon);
                sqlCon.Open();

                DataSet ds = new DataSet();
                sqlData.Fill(ds, tablename);
                return ds;
            }
        }

        public static SqlDataReader SqlDataRead(SqlCommand sqlCmd)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                sqlCmd.Connection = sqlCon;
                SqlDataReader sqlreader = sqlCmd.ExecuteReader();
                return sqlreader;
            }
        }
    }

}
