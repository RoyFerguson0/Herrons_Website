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
        // Opening Connection to Database
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

        // Closing Connection to Database
        public static void closeConnection(OleDbConnection cn)
        {
            cn.Close();
        } //Close Connection


       
        // Getting a Single Product from Database
        public static Product getProduct(Double id)
        {
            Product obj = new Product();

            OleDbConnection conn = openConnection();
            string sqlStr = "SELECT * FROM tblProducts" +
                " WHERE ProductID=" + id;

            OleDbCommand cmd = new OleDbCommand(sqlStr, conn);

            // Execute reader for Generate Reader - On diagram
            OleDbDataReader reader = cmd.ExecuteReader(); // Read one record at a time

            while (reader.Read())
            {
                obj.setProductID(Convert.ToInt32(reader["ProductID"]));
                obj.setProductName(reader["ProductName"].ToString());
                obj.setProductDescription(reader["ProductDescription"].ToString());
                obj.setProductPrice(Convert.ToDouble(reader["ProductPrice"].ToString()));
                obj.setProductImage(reader["ProductImage"].ToString());
                obj.setProductCategory(reader["ProductCategory"].ToString());

            }
            reader.Close();
            conn.Close();

            return obj;

        } // getProduct

        // Inserting Product Data into Database
        public static int createProduct(String ProductName, String ProductDesc, Double ProductPrice, String ProductImage, String ProductCategory)
        {
            //Need to know where the database is and what you are going to add to it

            OleDbConnection conn = openConnection();  // Communicate with database

            String sqlStr = "INSERT into tblProducts([ProductName], [ProductDescription], [ProductPrice], [ProductImage], [ProductCategory])" +     //What you are wanting to add 
                " VALUES('" + ProductName + "', '" + ProductDesc + "', '" + ProductPrice + "', '" + ProductImage + "', '" + ProductCategory + "')";

            OleDbCommand cmd = new OleDbCommand(sqlStr, conn);   // Needs to be the right way round
            // Line above is what the line below is doing 
            // cmd.CommandText = sqlStr;
            // cmd.Connection = conn;

            cmd.ExecuteNonQuery(); //Non Query for insert, update, delete. Anything else would be scalar e.g. Get information.

            cmd.CommandText = "SELECT @@IDENTITY";

            int studentID = Convert.ToInt32(cmd.ExecuteScalar());   // Is going to get primary key - Gets one piece of data the Scalar value

            closeConnection(conn); // To close the database

            return studentID;

        } //createProduct

        // Updating a Products Information
        public static bool updateProduct(int ProductID, String ProductName, String ProductDesc, Double ProductPrice, String ProductImage, String ProductCategory)
        {
            OleDbConnection conn = openConnection();

            string sqlStr = "UPDATE tblProducts SET [ProductName] = '" + ProductName + "',[ProductDescription] = '" + ProductDesc +
                "',[ProductPrice] = '" + ProductPrice + "',[ProductImage] = '" + ProductImage + "',[ProductCategory] = '" + ProductCategory + 
                "' WHERE ProductID=" + ProductID;

            OleDbCommand cmd = new OleDbCommand(sqlStr, conn);

            int count = cmd.ExecuteNonQuery();

            conn.Close();

            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        } // UpdateProduct

        // Removing a Product from Database
        public static bool removeProduct(int id)
        {

            OleDbConnection conn = openConnection();
            string sqlStr = "DELETE FROM tblProducts WHERE ProductID=" + id;

            OleDbCommand cmd = new OleDbCommand(sqlStr, conn);

            int count = cmd.ExecuteNonQuery();

            conn.Close();

            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        } // remove Product



    }
}