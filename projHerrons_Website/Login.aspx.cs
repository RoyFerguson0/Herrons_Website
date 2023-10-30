using projHerrons_Website.App_Code.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projHerrons_Website
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            Account accountObj = new Account(username, password);
            int userNum = accountObj.validateLogin();

            if (userNum != -1)
            {
                Account AccOjb = new Account();
                AccOjb.loadAccount(userNum);
                // NEED TO SET PERMANENT ID FOR LOGGED IN USERS + STATUS


                FormsAuthentication.RedirectFromLoginPage(username, true);
                lblOutput.Text = "Validated";
            }
            else
            {
                lblOutput.Text = "Invalid Login";
            }
        }
    }
}