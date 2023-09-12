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
    public class ClietnDataAccess
    {

        public void InsertStoreProceClientInfo(string clientName,string mobileNo,string clientEmail,
                                                string clientPassword,string gender,DateTime clientBirthday)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;

            con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());

            string query = "insert into ClientInfo values (ClientName=@clientName,ClientNumber=@mobileNo,ClientEmail=@clientEmail,ClientPassword=@clientPassword,ClientGenderId=@gender,CliendDOB=@clientBirthday)";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ClientName", clientName);
            cmd.Parameters.AddWithValue("@ClientNumber", mobileNo);
            cmd.Parameters.AddWithValue("@ClientEmail", clientEmail);
            cmd.Parameters.AddWithValue("@ClientPassword", clientPassword);
            cmd.Parameters.AddWithValue("@ClientGenderId", gender);
            cmd.Parameters.AddWithValue("@CliendDOB", clientBirthday);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
           

            //    //objCli.ClientDOB = DateTime.Now;
            //    //objCli.ClientDOB = new DateTime(1999, 12, 23); // Example date of birth
            //                                                   //  objCli.CreatedOn = DateTime.Now;

            //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());
            //    //create Connection also configurationManager 
            //    string query = "InsertClientInfo";
            //   // string query = "insert into ClientInfo values()";

            //    //create query
            //    //create command
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //    cmd.Parameters.Add("@ClientId", SqlDbType.Int).Value = 5;
            //    cmd.Parameters.Add("@ClientName", SqlDbType.VarChar).Value = "kala";
            //    cmd.Parameters.Add("@ClientNumber", SqlDbType.VarChar).Value = "958685555";
            //    cmd.Parameters.Add("@ClientEmail", SqlDbType.VarChar).Value = "kala@12gmail.com";
            //    cmd.Parameters.Add("@ClientPassword", SqlDbType.VarChar).Value = "abhilal";
            //    cmd.Parameters.Add("@ClientGenderId", SqlDbType.Int).Value = 1;

            //    cmd.Parameters.Add("@ClientDOB", SqlDbType.DateTime).Value = new DateTime(1991, 2, 23);
            //    cmd.Parameters.Add("@OperationId", SqlDbType.Int).Value = 2;
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();


            //    string qu = "Select * from ClientInfo";
            //    SqlCommand sqc = new SqlCommand(qu, con);
            //    con.Open();
            //    SqlDataReader red = sqc.ExecuteReader();
            //    if (red.HasRows)
            //    {
            //        while (red.Read())
            //        {
            //            Console.WriteLine("{0}     {1}    {2}    {3}   {4}   {5}    {6}   {7}", red["ClientId"],
            //                red["ClientName"], red["ClientNumber"], red["ClientEmail"], red["ClientPassword"]
            //                , red["ClientGenderId"], red["ClientDOB"], red["OperationId"]);
            //        }
            //    }

        }




        public bool InsertLogin(string userName,string password,out string validationMessage,out string emailval, out string passwordval)
        {

            SqlConnection con=null;
            SqlCommand cmd;



            //useremail check exists or not
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());

            string checkQuery = "select count(*) from ClientInfo where ClientEmail=@ClientEmail";
            cmd = new SqlCommand(checkQuery, con);
            cmd.Parameters.AddWithValue("@ClientEmail", userName);
            con.Open();
            int row =(int) cmd.ExecuteScalar();
            con.Close();
           
            if (row == 0)
            {
             emailval = "useremail not exists";
            }
            else
            {
                
                emailval = "UserEmail is verified";
            }

            //check password
            string checkQueryPassword = "select count(*) from ClientInfo where ClientPassword=@ClientPassword";
            cmd = new SqlCommand(checkQueryPassword, con);
            cmd.Parameters.AddWithValue("@ClientPassword", password);
            con.Open();
            row = (int)cmd.ExecuteScalar();
            con.Close();

            if (row == 0)
            {

                passwordval = "user password  not exists";
            }
            else
            {

                passwordval = "Userpassword is verified";
            }

            //checkQuery both
            string query = "select count(*) from ClientInfo where ClientEmail=@ClientEmail and ClientPassword=@ClientPassword";
                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ClientEmail", userName);
                cmd.Parameters.AddWithValue("@ClientPassword", password);
                con.Open();
                 row = (int)cmd.ExecuteScalar();

                con.Close();
                validationMessage = row == 0 ? "credentials not matched" : "login Successfull";
                return row > 0;
            

            

    
            //ClientInfoModel objClientLogin = new ClientInfoModel();
            //objClientLogin.ClientEmail = "karanshah2311@gmail.com";
            //objClientLogin.ClientPassword = "Karanshah@2312";

            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["storegeproce"].ToString());
            //string query = "Select * from "
            //SqlCommand cmd = new SqlCommand(query, con);
            //cmd.CommandType = System.Data.CommandType.Text;

            //con.Open();

            //if (objClientLogin.ClientEmail == "karanshah2311@gmail.com" && objClientLogin.ClientPassword == "Karanshah@2312")
            //{
            //    Console.WriteLine("Login successful");
            //    cmd.ExecuteNonQuery();
            //}
            //else
            //{
            //    Console.WriteLine("Error please check username and password ");
            //}

            //con.Close();
        }


    }

}
