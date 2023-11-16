using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

                //HttpCookie objCookie = new HttpCookie("accessCookie");
                //objCookie["colour"] = ddlAccessibility.SelectedValue;

                //objCookie.Expires = DateTime.Now.Add(new TimeSpan(1, 0, 0, 0));

                //Response.Cookies.Add(objCookie);

            }
            //if (Request.Cookies["accessCookie"].ToString() == null)
            //{
            //    HttpCookie objCookie = new HttpCookie("accessCookie");
            //    objCookie["colour"] = ddlAccessibility.SelectedValue;

            //    objCookie.Expires = DateTime.Now.Add(new TimeSpan(1, 0, 0, 0));

            //    Response.Cookies.Add(objCookie);
            //}
            //else
            //{
            //    HttpCookie objCookie = new HttpCookie("accessCookie");
            //    ddlAccessibility.SelectedValue = objCookie["colour"].ToString();
            //}

            //System.Diagnostics.Debug.WriteLine("first::: " + Request.Cookies["accessCookie"].ToString());
            //if (Request.Cookies["accessCookie"]["colour"] == null)
            //{

            //}
            //else if (Request.Cookies["accessCookie"]["colour"] == "Standard" || Request.Cookies["accessCookie"]["colour"] == "Select")
            //{
            //    HttpCookie objCookie = new HttpCookie("accessCookie");

            //    objCookie.Expires = DateTime.Now.AddDays(-1);

            //    Response.Cookies.Add(objCookie);

            //    System.Diagnostics.Debug.WriteLine("second::: " + Request.Cookies["accessCookie"]["colour"]);
            //}
            //else
            //{

            //    HomeContent.Style["background-color"] = Request.Cookies["accessCookie"]["colour"].ToString();

            //    System.Diagnostics.Debug.WriteLine("third::: " + Request.Cookies["accessCookie"]["colour"]);
            //}




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

        protected void btnSaveColour_Click(object sender, EventArgs e)
        {
            HttpCookie objCookie = new HttpCookie("accessCookie");
            objCookie["colour"] = ddlAccessibility.SelectedValue;

            objCookie.Expires = DateTime.Now.Add(new TimeSpan(1, 0, 0, 0));

            Response.Cookies.Add(objCookie);
        }

       
    }
}