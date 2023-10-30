using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace projExternalWS
{
    /// <summary>
    /// Summary description for FoodSize
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class FoodSize : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public double SizeOfFood(String size, Double cost)
        {
            double price = 0;

            switch(size)
            {
                case "Small":
                    price = cost + 1.50;
                    break;
                case "Medium":
                    price = cost + 2.00;
                    break;
                case "Large":
                    price = cost + 3.00;
                    break;
            }

            return price;
        }
    }
}
