﻿using projHerrons_Website.App_Code.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projHerrons_Website
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.MaintainScrollPositionOnPostBack = true;
            if (Session["loggedInStatus"] == null)
            {
                Session["loggedInStatus"] = "";
            }
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                hylSignUp.Visible = false;
                String status = Session["loggedInStatus"].ToString();



                System.Diagnostics.Debug.WriteLine(Session["loggedInStatus"]);
                if (status == "Admin")
                {
                    hylAdmin.Visible = true;
                }
                else
                {
                    hylAdmin.Visible = false;
                }

            }
            else
            {
                Session["loggedInStatus"] = "";
            }
        }
    }
}