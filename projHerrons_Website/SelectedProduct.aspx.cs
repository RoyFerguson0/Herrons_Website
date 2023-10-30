using projHerrons_Website.App_Code.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projHerrons_Website
{
    public partial class SelectedProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   
           
            if (Request.QueryString["id"] != null)
            {
                    

                lvProduct.DataSourceID = null;
                lvProduct.DataSource = SqlDataSource1;
                lvProduct.DataBind();

                int id = Convert.ToInt32(Request.QueryString["id"]);


                String ID = Request.QueryString["id"];
                String Name = Request.QueryString["name"];
                String Desc = Request.QueryString["Desc"];
                String Price = Request.QueryString["Price"];
                String Image = Request.QueryString["Image"];
                String Category = Request.QueryString["Category"];



                lblProductID.Text = ID;
                lblProductName.Text = Name;
                lblProductDesc.Text = Desc;
                lblProductPrice.Text = Price;
                imgProductImage.ImageUrl = Image;
                lblProductCategory.Text = Category;

            }


        }

        protected void ddlSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            refFoodSize.FoodSize dpObj = new refFoodSize.FoodSize();
            try
            {
                double cost = dpObj.SizeOfFood(ddlSize.SelectedValue.ToString(), Convert.ToDouble(lblProductPrice.Text));
                lblProductPrice.Text = cost.ToString();
            }
            catch (Exception ex) { 
            }
        }
    }
}