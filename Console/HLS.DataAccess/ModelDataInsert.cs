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
    public class ModelDataInsert
    {

        public void InsertStoreProceClientInfo()
        {
           
            //objCli.ClientDOB = DateTime.Now;
            //objCli.ClientDOB = new DateTime(1999, 12, 23); // Example date of birth
                                                           //  objCli.CreatedOn = DateTime.Now;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());
            //create Connection also configurationManager 
            string query = "InsertClientInfo";
            //create query
            //create command
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@ClientId", SqlDbType.Int).Value = 4;
            cmd.Parameters.Add("@ClientName", SqlDbType.VarChar).Value = "Abhi";
            cmd.Parameters.Add("@ClientNumber", SqlDbType.VarChar).Value = "958685555";
            cmd.Parameters.Add("@ClientEmail", SqlDbType.VarChar).Value = "abhi@12gmail.com";
            cmd.Parameters.Add("@ClientPassword", SqlDbType.VarChar).Value = "abhilal";
            cmd.Parameters.Add("@ClientGenderId", SqlDbType.Int).Value = 1;

            cmd.Parameters.Add("@ClientDOB", SqlDbType.DateTime).Value = new DateTime(1991, 2, 23);
            cmd.Parameters.Add("@OperationId", SqlDbType.Int).Value = 2;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            string qu = "Select * from ClientInfo";
            SqlCommand sqc = new SqlCommand(qu, con);
            con.Open();
            SqlDataReader red = sqc.ExecuteReader();
            if (red.HasRows)
            {
                while (red.Read())
                {
                    Console.WriteLine("{0}     {1}    {2}    {3}   {4}   {5}    {6}   {7}", red["ClientId"],
                        red["ClientName"], red["ClientNumber"], red["ClientEmail"], red["ClientPassword"]
                        , red["ClientGenderId"], red["ClientDOB"], red["OperationId"]);
                }
            }

        }

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

        public void InsertStoreProCategory()
        {
            
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());
            string query = "InsertCategoryType";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //  cmd.Parameters.Add("@Id", SqlDbType.Int).Value = objCli.Id;
            cmd.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = "Mensfabric";
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void InsertStoreProBill()
        {
           

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());
            string query = "InsertBill";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            // cmd.Parameters.Add("@Id", SqlDbType.Int).Value = objCli.Id;
            cmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = 3;
            cmd.Parameters.Add("@ItemQuantity", SqlDbType.Int).Value = 6;
            cmd.Parameters.Add("@ClientId", SqlDbType.Int).Value = 7;
            cmd.Parameters.Add("@PaymentTypeId", SqlDbType.Int).Value = 4;
            cmd.Parameters.Add("@CreatedOn", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@TotalBill", SqlDbType.Int).Value = 22;
            cmd.Parameters.Add("@OperationId", SqlDbType.Int).Value = 1;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

}
