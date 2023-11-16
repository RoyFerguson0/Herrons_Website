using projHerrons_Website.App_Code.BLL;
using System;
using System.Collections;
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

                int hits = Convert.ToInt32(ds.Tables[0].Rows[0]["selectedProdHits"]);
                hits++;
                // lblHits.Text = hits.ToString();

                ds.Tables[0].Rows[0]["selectedProdHits"] = hits.ToString();
                ds.WriteXml(Server.MapPath("/App_Data/NumberOfHits.xml"));
            }

            if (Session["CART"] == null)
            {
                Response.Redirect("Products.aspx");
            }
            if (!IsPostBack)
            {
                updateCartSummary();
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



                //lblProductID.Text = ID;
                lblProductName.Text = Name;
                lblProductDesc.Text = Desc;

                refFoodSize.FoodSize dpObj = new refFoodSize.FoodSize();
                try
                {
                    double cost = dpObj.SizeOfFood(ddlSize.SelectedValue.ToString(), Convert.ToDouble(Price));
                    lblProductPrice.Text = cost.ToString();
                }
                catch (Exception ex)
                {
                }

                imgProductImage.ImageUrl = Image;
                //lblProductCategory.Text = Category;

            }


        }

        protected void ddlSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            refFoodSize.FoodSize dpObj = new refFoodSize.FoodSize();
            try
            {

                String Price = Request.QueryString["Price"];
                double cost = dpObj.SizeOfFood(ddlSize.SelectedValue.ToString(), Convert.ToDouble(Price));
                lblProductPrice.Text = cost.ToString();
            }
            catch (Exception ex) { 
            }
        }

        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                CartItem Equipment = new CartItem();
                Equipment.setProductID(Convert.ToInt32(Request.QueryString["id"]));
                Equipment.setItemName(lblProductName.Text);
                Equipment.setCost(Convert.ToDouble(lblProductPrice.Text));
                Equipment.setProductSize(ddlSize.SelectedValue.ToString());
                Equipment.setQuantity(1);

                ArrayList arrCart = (ArrayList)Session["CART"];

                bool productExists = false;
                int storedItem = 0;
                int QuantityOfProduct = 0;

                for (int i = 0; i < arrCart.Count; i++)
                {
                    CartItem productStored = (CartItem)arrCart[i];
                    if ((productStored.getProductID().Equals(Equipment.getProductID())) & (productStored.getProductSize().Equals(Equipment.getProductSize())))
                    {
                        productExists = true;

                        QuantityOfProduct = productStored.getQuantity();

                        storedItem = i;
                    }
                }
                if (productExists)
                {
                    Equipment.setQuantity(QuantityOfProduct += 1);

                    arrCart.RemoveAt(storedItem);
                }

                arrCart.Add(Equipment);
                Session.Add("CART", arrCart);
                updateCartSummary();
            }catch (Exception ex)
            {

            }
        }

        private void updateCartSummary()
        {
            // get number of items in cart & show in link button
            ArrayList arrCart = (ArrayList)Session["CART"];
            int totalItems = arrCart.Count;
            int totalQuantity = 0;
            // go through items in the cart (ArrayList) and add the details
            for (int loop = 0; loop < totalItems; loop++)
            {
                CartItem cartItem = (CartItem)arrCart[loop];
                totalQuantity += cartItem.getQuantity();

            }//for
            HyperLink hylBasket = (HyperLink)this.Master.FindControl("hylBasket");

            hylBasket.Text =  "Basket (" + totalQuantity + ")";
            

        }
    }
}