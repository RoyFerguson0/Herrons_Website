using projHerrons_Website.App_Code.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projHerrons_Website
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(txtFirstName.Text);
            if (txtFirstName.Text != "" || txtLastName.Text != "" || txtEmail.Text != "" || txtPassword.Text != "" || txtPasswordRepeat.Text != "")
            {
                if (txtPassword.Text == txtPasswordRepeat.Text)
                {
                    if (chkTerms.Checked)
                    {
                        Account objUser = new Account();
                        objUser.setFirstName(txtFirstName.Text);
                        objUser.setLastName(txtLastName.Text);
                        objUser.setEmail(txtEmail.Text.ToString());
                        objUser.setPassword(txtPassword.Text);
                        objUser.setStatus("User");
                        objUser.createNewAccount();

                        lblOuput.Text = "Created Account" + objUser.getUserID();
                    }
                    else
                    {
                        lblOuput.Text = "Check The Terms!!!";
                    }
                }
                else
                {
                    lblOuput.Text = "Passwords Don't Match";
                }
            }
            else
            {
                lblOuput.Text = "Fill All Boxes In!!!!";
            }
        }
    }
}