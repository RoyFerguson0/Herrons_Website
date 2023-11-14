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

        // Default Constructor
        public Product()
        {

        }

        // Update Product Information
        public void updateProduct()
        {
            DataAccess2.updateProduct(this.ProductID, this.ProductName, this.ProductDesc, this.ProductPrice, this.ProductImage, this.ProductCategory);
        }

        // Delete Product Information
        public bool deleteProduct()
        {
            return DataAccess2.removeProduct(this.ProductID);
        }

        // Create New Product
        public void createNewProduct()
        {
            this.ProductID = DataAccess2.createProduct(this.ProductName, this.ProductDesc, this.ProductPrice, this.ProductImage, this.ProductCategory);
        }

        // Populates a Product Object
        public void loadProduct(int ProductID)
        {
            // Using a Temporary Product Object to populate Data Fields
            Product tmpProductObj = DataAccess2.getProduct(ProductID);
            this.ProductID = Convert.ToInt32(tmpProductObj.getProductID());
            this.ProductName = tmpProductObj.getProductName();
            this.ProductDesc = tmpProductObj.getProductDesc();
            this.ProductPrice = tmpProductObj.getProductPrice();
            this.ProductImage = tmpProductObj.getProductImage();
            this.ProductCategory = tmpProductObj.getProductCategory();
        }


        // Setters

        // ID
        public void setProductID(int ProductID)
        {
            this.ProductID = ProductID;
        }

        // Product Name
        public void setProductName(String ProductName)
        {
            this.ProductName = ProductName;
        }

        // Product Description
        public void setProductDescription(String ProductDesc)
        {
            this.ProductDesc = ProductDesc;
        }

        // Product Price
        public void setProductPrice(Double ProductPrice)
        {
            this.ProductPrice = ProductPrice;
        }

        // Product Image
        public void setProductImage(String ProductImage)
        {
            this.ProductImage = ProductImage;
        }

        // Product Category
        public void setProductCategory(String ProductCategory)
        {
            this.ProductCategory = ProductCategory;
        }


        // Getters

        // ID
        public int getProductID()
        {
            return this.ProductID;
        }

        // Product Name
        public String getProductName()
        {
            return this.ProductName;
        }

        // Product Description
        public String getProductDesc()
        {
            return this.ProductDesc;
        }

        // Product Price
        public Double getProductPrice()
        {
            return this.ProductPrice;
        }

        // Product Image
        public String getProductImage()
        {
            return this.ProductImage;
        }

        // Product Category
        public String getProductCategory()
        {
            return this.ProductCategory;
        }



    }
}