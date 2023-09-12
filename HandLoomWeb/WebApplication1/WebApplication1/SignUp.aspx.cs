using HLS.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string clientName = TextBox1.Text;
            string mobileNo = TextBox2.Text;
            string clientEmail = TextBox3.Text;
            string clientPassword = TextBox4.Text;
            string gender = RadioButtonList1.SelectedValue;
            DateTime clientBirthday = Calendar1.SelectedDate;

            ClietnDataAccess objClientLogin = new ClietnDataAccess();

            objClientLogin.InsertStoreProceClientInfo(clientName,mobileNo,clientEmail,clientPassword,gender,clientBirthday);




        }
    }
}