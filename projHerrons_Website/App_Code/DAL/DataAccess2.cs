using projHerrons_Website.App_Code.BLL;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace projHerrons_Website.App_Code.DAL
{
    public class DataAccess2
    {

        public static OleDbConnection openConnection()  //openConnection is the object
        {
            string connStr = "Provider=Microsoft.ACE.OLEDB.12.0; data source=" +
                System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/Information.accdb");
            //First half to do with provider (From Provider to 12.0) the second part is where it is located e.g. data source=C:\\Users\\50004216\\Download\\bmcstudents.accdb.
            // Hard coding it is not the best as it will not run on someone elses machine.

            try
            {
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                return null;
            }


        }// Open Connection

        public static void closeConnection(OleDbConnection cn)
        {
            cn.Close();
        } //Close Connection


        public static Product getProduct(int id)
        {
            Product obj = new Product();

            OleDbConnection conn = openConnection();
            string sqlStr = "SELECT ProductID, ProductName, ProductDescription, ProductPrice, ProductImage, ProductCategory FROM tblProducts" +
                " WHERE ProductID=" + id;

            OleDbCommand cmd = new OleDbCommand(sqlStr, conn);

            // Execute reader for Generate Reader - On diagram
            OleDbDataReader reader = cmd.ExecuteReader(); // Read one record at a time

            while (reader.Read())
            {
                obj.setProductID(Convert.ToInt32(reader["ProductID"]));
                obj.setProductName(reader["ProductName"].ToString());
                obj.setProductDescription(reader["ProductDescription"].ToString());
                obj.setProductPrice(reader["ProductPrice"].ToString());
                obj.setProductImage(reader["ProductImage"].ToString());
                obj.setProductCategory(reader["ProductCategory"].ToString());

            }
            reader.Close();
            conn.Close();

            return obj;

        } // getStudent


    }
}