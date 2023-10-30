using projHerrons_Website.App_Code.BLL;
using System;
using System.Collections.Generic;
using System.Data;
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
            if (!IsPostBack)
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("/App_Data/NumberOfHits.xml"));     

                int hits = Convert.ToInt32(ds.Tables[0].Rows[0]["firstHits"]);
                hits++;
                // lblHits.Text = hits.ToString();

                ds.Tables[0].Rows[0]["firstHits"] = hits.ToString();
                ds.WriteXml(Server.MapPath("/App_Data/NumberOfHits.xml"));
            }
            
            if (Request.QueryString["id"] != null)
            {
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