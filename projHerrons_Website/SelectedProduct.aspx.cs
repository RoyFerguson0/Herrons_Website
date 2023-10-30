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
                }
               
            
        }
    }
}