using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HLS.DataAccess
{
  public class OperationDataAccess
    {
        public void InsertStoreProOperation()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());
            string query = "InsertOperation";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //     cmd.Parameters.Add("@OperationId", SqlDbType.Int).Value = objCli.Operation;
            cmd.Parameters.Add("@OperationName", SqlDbType.VarChar).Value = "fetch";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

    }
}
