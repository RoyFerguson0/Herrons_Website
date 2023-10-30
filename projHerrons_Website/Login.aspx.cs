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
            System.Diagnostics.Debug.WriteLine("Test2 " + username + ":" + password);
            Account accountObj = new Account(username, password);
            int userNum = accountObj.validateLogin();

            if (userNum != -1)
            {
                // Loading the Valid User to Get Status
                Account AccOjb = new Account();
                AccOjb.loadAccount(userNum);
                String status = AccOjb.getStatus();
                // Storing Status in a Session Variable so that it can be accessed on other web pages.
                Session["loggedInStatus"] = status;
                FormsAuthentication.RedirectFromLoginPage(username, true);
                
            }
            
        }
    }
}