using projHerrons_Website.App_Code.BLL;
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
            if (!IsPostBack) { 
            if (Request.QueryString["cat"]!= null)
            {
                

                lvProducts.DataSourceID = null;
                lvProducts.DataSource = SqlDataSource2;
                lvProducts.DataBind();
            }
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
            //Product obj = new Product();
            //obj.loadProduct(Convert.ToInt32(e.CommandArgument));
            //String ID = obj.getProductID().ToString();
            //String Name = obj.getProductName();
            //String Desc = obj.getProductDesc();
            //String Price = obj.getProductPrice();
            //String Image = obj.getProductImage().ToString();
            //String Category = obj.getProductCategory().ToString();
            Response.Redirect("SelectedProduct.aspx?id=" + e.CommandArgument.ToString());

            //Response.Redirect("SelectedProduct.aspx?id=" + ID + "&name=" + Name + "&Desc=" + Desc +
            //                    "&Price=" + Price + "&Image=" + Image + "&Category=" + Category);


        }
    }
}