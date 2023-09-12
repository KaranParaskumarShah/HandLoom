using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLS.DataAccess
{
    public class ItemDataAccess
    {

        public void InsertStoreProItemType()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());
            string query = "InsertItemType";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //  cmd.Parameters.Add("@Id", SqlDbType.Int).Value = objCli.PaymentId;
            cmd.Parameters.Add("@ItemName", SqlDbType.VarChar).Value = "Sadra";

            cmd.Parameters.Add("@ItemPrice", SqlDbType.Int).Value = 150;
            cmd.Parameters.Add("@CategoryId", SqlDbType.VarChar).Value = 7;
            cmd.Parameters.Add("@ItemQuantity", SqlDbType.VarChar).Value = 160;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
