using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace projHerrons_Website
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)  //Page is required as it already has access to Page
            {
                if (User.Identity.IsAuthenticated)
                {
                    lblGreeting.Text = "Welcome " + User.Identity.Name;
                    
                }
                else
                {
                    lblGreeting.Text = "Welcome";
                }
            }
        }

        protected void btnProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnBasket_Click(object sender, EventArgs e)
        {
            Response.Redirect("Basket.aspx");
        }
    }
}