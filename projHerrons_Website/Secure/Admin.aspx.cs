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
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblHitsUserVisits.Text = Application["visits"].ToString();
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("/App_Data/NumberOfHits.xml"));      

            int hits = Convert.ToInt32(ds.Tables[0].Rows[0]["cookieHits"]); 
            int hits2 = Convert.ToInt32(ds.Tables[0].Rows[0]["firstHits"]);
            lblHitsProducts.Text = hits.ToString();
            lblHitsSelectedProducts.Text = hits2.ToString();
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
                        String fName = obj.getFirstName();
                        String lName = obj.getLastName();
                        bool isNumber = false;
                        for(int i = 0; i < fName.Length; i++)
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
                            lblUserFound.Text = "There is a number is First Name or Last Name";
                        }
                        else
                        {
                            obj.updateAccount();
                            txtUpdateID.Text = "";
                            txtUpdateFName.Text = "";
                            txtUpdateLName.Text = "";
                            txtUpdateEmail.Text = "";
                            txtUpdatePassword.Text = "";
                            txtUpdateStatus.Text = "";
                        }


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

        protected void btnCreateProduct_Click(object sender, EventArgs e)
        {
            lblCreateMessage.Text = "";
            Product obj = new Product();
            try
            {
                obj.setProductName(txtCreateProductName.Text);
                obj.setProductDescription(txtCreateProductDesc.Text);
                obj.setProductPrice(Convert.ToDouble(txtCreateProductPrice.Text));
                obj.setProductImage("~/ImagesProducts/" + fuCreateProductImage.FileName);
                obj.setProductCategory(txtCreateProductCategory.Text);

                if (obj.getProductName() != "" & obj.getProductDesc() != "" & obj.getProductPrice() != -1
                   & obj.getProductImage() != "" & obj.getProductCategory() != "")
                {

                    obj.createNewProduct();
                }
                else
                {
                    lblCreateMessage.Text = "Fields not Filled in?";
                }
            }catch (Exception ex)
            {
                lblCreateMessage.Text = "Fill All Fields In?";
            }


        }

        protected void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            lblProductFound.Text = "";
            if (txtUpdateProductID.Text != "")
            {
                Product obj = new Product();
                String strID = txtUpdateProductID.Text;
                obj.loadProduct(Convert.ToInt32(strID));
                if (obj.getProductID() != 0)
                {
                    obj.setProductName(txtCreateProductName.Text);
                    obj.setProductDescription(txtCreateProductDesc.Text);
                    try
                    {
                        obj.setProductPrice(Convert.ToDouble(txtCreateProductPrice.Text));
                    }catch (Exception ex)
                    {

                    }
                    obj.setProductImage("~/Images/" + fuCreateProductImage.FileName);
                    obj.setProductCategory(txtCreateProductCategory.Text);
                    if (obj.getProductID() != 0 & obj.getProductName() != "" & obj.getProductDesc() != "" & obj.getProductPrice() != -1
                        & obj.getProductImage() != "" & obj.getProductCategory() != "")
                    {
                        obj.updateProduct();
                    }
                    else
                    {
                        lblProductFound.Text = "Enter All Data in Fields???";
                    }
                }
                else
                {
                    lblProductFound.Text = "Enter Valid ID";
                }
            }
            else
            {
                lblProductFound.Text = "Enter ID!!!!";
            }
        }

        protected void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            lblProductFound.Text = "";
            if (txtUpdateProductID.Text != "")
            {
                Product obj = new Product();
                obj.loadProduct(Convert.ToInt32(txtUpdateProductID.Text));
                if (obj.getProductID() != 0)
                {
                    txtUpdateProductID.Text = obj.deleteProduct().ToString();
                }
                else
                {
                    lblProductFound.Text = "Enter Valid ID";
                }
            }
            else
            {
                lblProductFound.Text = "Enter ID!!!!!";
            }
        }

        protected void btnFindProductID_Click(object sender, EventArgs e)
        {
            lblProductFound.Text = "";
            if (txtUpdateProductID.Text != "")
            {
                Product obj = new Product();
                obj.loadProduct(Convert.ToInt32(txtUpdateProductID.Text));
                if (obj.getProductID() != 0)
                {
                    txtUpdateProductName.Text = obj.getProductName();
                    txtUpdateProductDesc.Text = obj.getProductDesc();
                    txtUpdateProductPrice.Text = obj.getProductPrice().ToString();
                    txtUpdateProductImage.Text = obj.getProductImage();
                    txtUpdateProductCategory.Text = obj.getProductCategory();
                }
                else
                {
                    lblProductFound.Text = "ID Doesn't Exist???";
                }
            }
            else
            {
                lblProductFound.Text = "Enter ID!!!!";
            }
        }

        protected void btnUploadImage_Click(object sender, EventArgs e)
        {
            String uploadedImgPath = "";
            if (fuUploadImages.HasFile)
            {
                uploadedImgPath = "~/ImagesProducts/" + fuUploadImages.FileName;
                fuUploadImages.SaveAs(Server.MapPath(uploadedImgPath));
            }
            else
            {
                lblProductImageUploaded.Text = "Need to Select an Image?";
            }
        }
    }
}