using HLS.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string userName = TextBox1.Text;
            string password = TextBox2.Text;
            

            ClietnDataAccess objClientLogin = new ClietnDataAccess();
          bool exists=  objClientLogin.InsertLogin(userName,password,out string validationMessage,out string emailval,out string passwordval);

            if (exists)
            {
                Session["usersname"] = userName;
              //  Response.Redirect("redirect.aspx");
                errorMessage.Text = validationMessage;
            }
            else
            {
                errorMessage.Text = validationMessage;
                checkEmail.Text = emailval;
                checkPassword.Text = passwordval;
            }
        }

        //SqlConnection con=null;







    }

        
}
