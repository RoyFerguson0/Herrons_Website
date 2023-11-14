using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace projHerrons_Website.App_Code.BLL
{
    public class CartItem
    {
        private int productID = 0;
        private string itemName = null;
        private double cost = 0;
        private int quantity = 0;
        private string productSize = null;

        // Default Constructor
        public CartItem()
        {

        }

        // Get ID
        public int getProductID()
        {
            return this.productID;
        }
        
        // Set ID
        public void setProductID(int productID)
        {
            this.productID = productID;
        }

        // Get Product Name
        public string getItemName()
        {
            return this.itemName;
        }

        // Set Product Name
        public void setItemName(string itemName)
        {
            this.itemName = itemName;
        }

        // Get Cost
        public double getCost()
        {
            return this.cost;
        }

        // Set Cost
        public void setCost(double cost)
        {
            this.cost = cost;
        }

        // Get Quantity
        public int getQuantity()
        {
            return this.quantity;
        }

        // Set Quantity
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        // Get Product Size
        public string getProductSize()
        {
            return this.productSize;
        }

        // Set Product Size
        public void setProductSize(string productSize)
        {
            this.productSize = productSize;
        }
        
    }
}