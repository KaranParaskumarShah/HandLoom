using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HLS.DataAccess
{
   public class PaymentDataAccess
    {
        public void InsertStoreProPayment()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());
            string query = "InsertPaymentType";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add("@PaymentId", SqlDbType.Int).Value = objCli.PaymentId;
            cmd.Parameters.Add("@PaymentTypeName", SqlDbType.VarChar).Value = "simp";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
