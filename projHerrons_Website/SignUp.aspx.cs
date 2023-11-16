using projHerrons_Website.App_Code.BLL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
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
            
            if (txtFirstName.Text != "" || txtLastName.Text != "" || txtEmail.Text != "" || txtPassword.Text != "" || txtPasswordRepeat.Text != "")
            {
                String fName = txtFirstName.Text;
                String lName = txtLastName.Text;
                bool isNumber = false;
                for (int i = 0; i < fName.Length; i++)
                {
                    if (char.IsDigit(fName[i]))
                    {
                        isNumber = true;
                        break;
                    }
                }
                for (int i = 0; i < lName.Length; i++)
                {
                    if (char.IsDigit(lName[i]))
                    {
                        isNumber = true;
                        break;
                    }
                }

                if (isNumber)
                {
                    lblOuput.Text = "There is a number is First Name or Last Name";
                }
                else
                {
                    bool emailValid = IsValidEmail(txtEmail.Text);
                    if (emailValid)
                    {
                        if (txtPassword.Text == txtPasswordRepeat.Text)
                        {
                            if (chkTerms.Checked)
                            {
                                Account objUser = new Account();

                                int validEmail = objUser.validEmail(txtEmail.Text);

                                if (validEmail == -1)
                                {
                                    objUser.setFirstName(txtFirstName.Text);
                                    objUser.setLastName(txtLastName.Text);
                                    objUser.setEmail(txtEmail.Text.ToString());
                                    objUser.setPassword(txtPassword.Text);
                                    objUser.setStatus("User");
                                    objUser.createNewAccount();

                                    lblOuput.Text = "Created Account" + objUser.getUserID();
                                    txtFirstName.Text = "";
                                    txtLastName.Text = "";
                                    txtEmail.Text = "";
                                    txtPassword.Text = "";
                                    txtPasswordRepeat.Text = "";
                                }
                                else
                                {
                                    lblOuput.Text = "Email Already Exists!!!!!!";
                                }
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
                        lblOuput.Text = "InValid Email";
                    }
                }
            }
            else
            {
                lblOuput.Text = "Fill All Boxes In!!!!";
            }
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        } // Email Validation

    }
}