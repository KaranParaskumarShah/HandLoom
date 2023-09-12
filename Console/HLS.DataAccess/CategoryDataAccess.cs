using HandLoomStoreModels;
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
    public class CategoryDataAccess
    {

        public void InsertStoreProCategory()
        {
            CategoryModel objcategory = new CategoryModel();
            objcategory.CategoryName = "lengha";

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());
            string query = "InsertCategoryType";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //  cmd.Parameters.Add("@Id", SqlDbType.Int).Value = objCli.Id;
            cmd.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = objcategory.CategoryName;

            con.Open();
            try
            {
                int row = cmd.ExecuteNonQuery();
            }


            finally
            {
                con.Close();
            }
        }

    }
}
