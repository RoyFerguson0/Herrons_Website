using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projHerrons_Website
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["addproduct"] = "false";
            if (Request.QueryString["cat"]!= null)
            {
                

                lvProducts.DataSourceID = null;
                lvProducts.DataSource = SqlDataSource2;
                lvProducts.DataBind();
            }
        }

        
        protected void lbnChips_Click(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx?cat=Chips");
        }

        protected void lbnAllProducts_Click(object sender, EventArgs e)
        {
            lvProducts.DataSource = null;
            lvProducts.DataSource = SqlDataSource1;
            lvProducts.DataBind();
        }

        protected void lvProducts_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Session["addproduct"] = "true";
            Response.Redirect("SelectedProduct.aspx?id=" + e.CommandArgument.ToString());
        }
    }
}