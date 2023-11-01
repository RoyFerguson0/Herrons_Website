using projHerrons_Website.App_Code.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projHerrons_Website
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnUpdateUser_Click(object sender, EventArgs e)
        {
            lblUserFound.Text = "";
            if (txtUpdateID.Text != "")
            {
                Account obj = new Account();
                String strID = txtUpdateID.Text;
                obj.loadAccount(Convert.ToInt32(strID));
                if (obj.getUserID() != 0)
                {
                    obj.setFirstName(txtUpdateFName.Text);
                    obj.setLastName(txtUpdateLName.Text);
                    obj.setEmail(txtUpdateEmail.Text);
                    obj.setPassword(txtUpdatePassword.Text);
                    obj.setStatus(txtUpdateStatus.Text);
                    if (obj.getUserID() != 0 & obj.getFirstName() != "" & obj.getLastName() != "" & obj.getEmail() != ""
                        & obj.getPassword() != "" & obj.getStatus() != "")
                    {
                        obj.updateAccount();
                    }
                    else
                    {
                        lblUserFound.Text = "Enter All Data in Fields???";
                    }
                }
                else
                {
                    lblUserFound.Text = "Enter Valid ID";
                }
            }
            else
            {
                lblUserFound.Text = "Enter ID!!!!";
            }
        }

        protected void btnDeleteUser_Click(object sender, EventArgs e)
        {
            lblUserFound.Text = "";
            if (txtUpdateID.Text != "")
            {
                Account obj = new Account();
                obj.loadAccount(Convert.ToInt32(txtUpdateID.Text));
                if (obj.getUserID() != 0)
                {
                    txtUpdateID.Text = obj.deleteAccount().ToString();
                }
                else
                {
                    lblUserFound.Text = "Enter Valid ID";
                }
            }
            else
            {
                lblUserFound.Text = "Enter ID!!!!!";
            }
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            lblUserFound.Text = "";
            if (txtUpdateID.Text != "")
            {
                Account obj = new Account();
                obj.loadAccount(Convert.ToInt32(txtUpdateID.Text));
                if (obj.getUserID() != 0)
                {
                    txtUpdateFName.Text = obj.getFirstName();
                    txtUpdateLName.Text = obj.getLastName();
                    txtUpdateEmail.Text = obj.getEmail();
                    txtUpdatePassword.Text = obj.getPassword();
                    txtUpdateStatus.Text = obj.getStatus();
                }
                else
                {
                    lblUserFound.Text = "ID Doesn't Exist???";
                }
            }
            else
            {
                lblUserFound.Text = "Enter ID!!!!";
            }
        }
    }
}