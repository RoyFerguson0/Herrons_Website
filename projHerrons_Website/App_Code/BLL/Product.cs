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
        private Double ProductPrice = -1;
        private String ProductImage;
        private String ProductCategory;

        public Product()
        {

        }

        public void updateProduct()
        {
            DataAccess2.updateProduct(this.ProductID, this.ProductName, this.ProductDesc, this.ProductPrice, this.ProductImage, this.ProductCategory);
        }

        public bool deleteProduct()
        {
            return DataAccess2.removeProduct(this.ProductID);
        }

        public void createNewProduct()
        {
            this.ProductID = DataAccess2.createProduct(this.ProductName, this.ProductDesc, this.ProductPrice, this.ProductImage, this.ProductCategory);
        }

        public void loadProduct(int ProductID)
        {
            Product tmpProductObj = DataAccess2.getProduct(ProductID);
            this.ProductID = Convert.ToInt32(tmpProductObj.getProductID());
            this.ProductName = tmpProductObj.getProductName();
            this.ProductDesc = tmpProductObj.getProductDesc();
            this.ProductPrice = tmpProductObj.getProductPrice();
            this.ProductImage = tmpProductObj.getProductImage();
            this.ProductCategory = tmpProductObj.getProductCategory();
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

        public void setProductPrice(Double ProductPrice)
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

        public int getProductID()
        {
            return this.ProductID;
        }


        public String getProductName()
        {
            return this.ProductName;
        }

        public String getProductDesc()
        {
            return this.ProductDesc;
        }

        public Double getProductPrice()
        {
            return this.ProductPrice;
        }

        public String getProductImage()
        {
            return this.ProductImage;
        }

        public String getProductCategory()
        {
            return this.ProductCategory;
        }



    }
}