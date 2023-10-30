using projHerrons_Website.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projHerrons_Website.App_Code.BLL
{
    public class Product
    {
        private int ProductID;
        private String ProductName;
        private String ProductDesc;
        private String ProductPrice;
        private String ProductImage;
        private String ProductCategory;

        

        public void loadProduct(int ProductID)
        {
            Product tmpProductObj = DataAccess2.getProduct(ProductID);
            this.ProductID = Convert.ToInt32(tmpProductObj.getProductID());
            this.ProductName = tmpProductObj.getProductName();
            this.ProductDesc = tmpProductObj.getProductDesc();
            this.ProductPrice = tmpProductObj.getProductPrice();
            this.ProductImage = tmpProductObj.getProductImage().ToString();
            this.ProductCategory = tmpProductObj.getProductCategory().ToString();
        }


        // Setters
        public void setProductID(int ProductID)
        {
            this.ProductID = ProductID;
        }

        public void setProductName(String ProductName)
        {
            this.ProductName = ProductName;
        }

        public void setProductDescription(String ProductDesc)
        {
            this.ProductDesc = ProductDesc;
        }

        public void setProductPrice(String ProductPrice)
        {
            this.ProductPrice = ProductPrice;
        }

        public void setProductImage(String ProductImage)
        {
            this.ProductImage = ProductImage;
        }

        public void setProductCategory(String ProductCategory)
        {
            this.ProductCategory = ProductCategory;
        }

        // Getters

        public String getProductID()
        {
            return this.getProductID();
        }

        public String getProductName()
        {
            return this.getProductName();
        }

        public String getProductDesc()
        {
            return this.getProductDesc();
        }

        public String getProductPrice()
        {
            return this.getProductPrice();
        }

        public Product getProductImage()
        {
            return this.getProductImage();
        }

        public int getProductCategory()
        {
            return this.getProductCategory();
        }



    }
}