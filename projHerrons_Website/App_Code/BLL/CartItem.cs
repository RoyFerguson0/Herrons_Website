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


        public CartItem()
        {

        }

        public int getProductID()
        {
            return this.productID;
        }
        
        public void setProductID(int productID)
        {
            this.productID = productID;
        }

        public string getItemName()
        {
            return this.itemName;
        }

        public void setItemName(string itemName)
        {
            this.itemName = itemName;
        }

        public double getCost()
        {
            return this.cost;
        }

        public void setCost(double cost)
        {
            this.cost = cost;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public string getProductSize()
        {
            return this.productSize;
        }

        public void setProductSize(string productSize)
        {
            this.productSize = productSize;
        }
        
    }
}