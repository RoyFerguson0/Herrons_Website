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
            if (Request.Cookies["rememberMe"] != null)
            {
                txtUsername.Text = Request.Cookies["rememberMe"]["username"].ToString();
                txtPassword.Text = Request.Cookies["rememberMe"]["password"].ToString();
            }
            if(lblOutput.Text == "")
            {
                lblOutput.Visible = false;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblOutput.Visible=false;
            String username = txtUsername.Text;
            String password = txtPassword.Text;
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

                // Remember me If checked
                if (chkRememberMe.Checked)
                {
                    HttpCookie objCookie = new HttpCookie("rememberMe");
                    objCookie["username"] = username;
                    objCookie["password"] = password;

                    objCookie.Expires = DateTime.Now.Add(new TimeSpan(0, 0, 3, 0));

                    Response.Cookies.Add(objCookie);
                }

            }
            else
            {
                lblOutput.Visible = true;
                lblOutput.Text = "Username or Password is wrong?";
            }
            
        }

        
    }
}