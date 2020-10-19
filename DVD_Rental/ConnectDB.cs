using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace DVD_Rental
{
    public class ConnectDB
    {
        public string [] auth(string id , string pw)
        {
            String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SquatDB;Integrated Security=True";
            SqlConnection objConn = new SqlConnection(connectionString);
            objConn.Open();

            string sql = "select IsAdministrator from User where Id = " + id + " and LoginPassword = " + pw + "";

            SqlCommand sqlCommand = objConn.CreateCommand();
            sqlCommand.CommandText = sql;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlCommand.Dispose();
            objConn.Close();

            if (sqlDataReader.HasRows)
            {
                //IDとパスワードが一致した場合
                string[] array = { sqlDataReader["IsAdminstrator"].ToString(), id };
                return array;
            }
            else
            {
                //IDとパスワードの組み合わせがない場合
                string[] array = {"-1", id};
                return array;
            }
        }
    }
}