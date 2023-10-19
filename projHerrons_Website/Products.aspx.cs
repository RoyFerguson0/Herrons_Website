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
            if (Request.QueryString["cat"]!= null)
            {
                DataList1.DataSourceID = null;
                DataList1.DataSource = SqlDataSource2;
                DataList1.DataBind();

                ListView1.DataSourceID = null;
                ListView1.DataSource = SqlDataSource2;
                ListView1.DataBind();
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            DataList1.DataSource = null;
            DataList1.DataSource = SqlDataSource1;
            DataList1.DataBind();

            ListView1.DataSource = null;
            ListView1.DataSource = SqlDataSource1;
            ListView1.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx?cat=Chips");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = GridView1.SelectedRow.Cells[1].Text;
            lblSelected.Text = id;
        }
    }
}