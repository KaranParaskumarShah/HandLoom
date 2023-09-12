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
    public class BillDataAccess
    {

        public void InsertStoreProBill()
        {

            BillModel objbillModel = new BillModel();
            objbillModel.ModifiedOn = new DateTime(2000, 2, 22);
            objbillModel.ItemId = 7;
            objbillModel.PurchasingItemQuantity = 3;
            objbillModel.TotalBill = 22;
            objbillModel.CreatedOn = DateTime.Now;
            objbillModel.ClientId = 4;
            objbillModel.PaymentId = 2;
            objbillModel.OperationId = 1;


            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());
            string query = "InsertBill";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            // cmd.Parameters.Add("@Id", SqlDbType.Int).Value = objCli.Id;
            cmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = objbillModel.ItemId;
            cmd.Parameters.Add("@ItemQuantity", SqlDbType.Int).Value = objbillModel.PurchasingItemQuantity;
            cmd.Parameters.Add("@ClientId", SqlDbType.Int).Value = objbillModel.ClientId;
            cmd.Parameters.Add("@PaymentTypeId", SqlDbType.Int).Value = objbillModel.PaymentId;
            cmd.Parameters.Add("@CreatedOn", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@TotalBill", SqlDbType.Int).Value = objbillModel.TotalBill;
            cmd.Parameters.Add("@OperationId", SqlDbType.Int).Value = objbillModel.OperationId;
            //cmd.Parameters.Add("@ModifiedOn")


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
