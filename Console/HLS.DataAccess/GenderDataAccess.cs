using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HLS.DataAccess
{
   public class GenderDataAccess
    {
        public void InsertStoreProGender()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());
            string query = "InsertClientGender";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@ClientGenderId", SqlDbType.Int).Value = 6;
            cmd.Parameters.Add("@ClientGenderName", SqlDbType.VarChar).Value = "Bi";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }

    }
}
