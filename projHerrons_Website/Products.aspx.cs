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
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("/App_Data/NumberOfHits.xml"));      // "/"  if you have it in a folder

                int hits = Convert.ToInt32(ds.Tables[0].Rows[0]["cookieHits"]); // Instead of 0 in tables you could put 'count'
                hits++;

                ViewState["hitsCookie"] = hits;

                ds.Tables[0].Rows[0]["cookieHits"] = hits.ToString();
                ds.WriteXml(Server.MapPath("/App_Data/NumberOfHits.xml"));

                if (!IsPostBack)
                {
                    // create cart for this session but only if session doesn't already exist
                    if (Session["CART"] == null)
                    {
                        ArrayList arrCart = new ArrayList();
                        Session["CART"] = arrCart;
                    }
                }

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
            try
            {
                lvProducts.DataSourceID = null;
                lvProducts.DataSource = SqlDataSource1;
                lvProducts.DataBind();
            }catch(Exception ex)
            {

            }
        }

        protected void lvProducts_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Product obj = new Product();
            int id = Convert.ToInt32(e.CommandArgument);

            obj.loadProduct(id);
            String ID = obj.getProductID().ToString();
            String Name = obj.getProductName();
            String Desc = obj.getProductDesc();
            String Price = obj.getProductPrice().ToString();
            String Image = obj.getProductImage().ToString();
            String Category = obj.getProductCategory().ToString();
            //Response.Redirect("SelectedProduct.aspx?id=" + e.CommandArgument.ToString());

            //System.Diagnostics.Debug.WriteLine(ID);
            //System.Diagnostics.Debug.WriteLine(Name);
            //System.Diagnostics.Debug.WriteLine(Desc);
            //System.Diagnostics.Debug.WriteLine(Price);
            //System.Diagnostics.Debug.WriteLine(Image);
            ////System.Diagnostics.Debug.WriteLine(Category);
            Response.Redirect("SelectedProduct.aspx?id=" + Server.UrlEncode(ID) + "&name=" + Server.UrlEncode(Name) + 
                "&Desc=" + Server.UrlEncode(Desc) + "&Price=" + Server.UrlEncode(Price) + "&Image=" + Server.UrlEncode(Image) + 
                "&Category=" + Server.UrlEncode(Category));


        }
    }
}