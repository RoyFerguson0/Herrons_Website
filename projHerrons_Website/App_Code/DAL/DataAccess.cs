using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace projHerrons_Website.App_Code.DAL
{
    public class DataAccess
    {
        public static OleDbConnection openConnection() //Open connection is the object
        {
            string connStr = "Provider=Microsoft.ACE.OLEDB.12.0; data source=" +
                System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/Information.accdb");

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

        } //Open Connection

        public static void closeConnection(OleDbConnection cn)
        {
            cn.Close();
        } // Close Connection

        public static int createAccount(String Firstname, String Lastname, String Email, String Password)
        {
            OleDbConnection conn = openConnection(); // Communicate With Database

            String sqlStr = "INSERT into tblAccounts(FirstName, LastName, Email, Password)" +
                "VALUES('" + Firstname + "', '" + Lastname + "', '" + Email + "' + '" + Password + "')";

            OleDbCommand cmd = new OleDbCommand(sqlStr, conn); 

            cmd.ExecuteNonQuery(); // Non Query For Insert, Update, Delete. Anything else would be Scalar e.g. Get Information 

            cmd.CommandText = "SELECT @@IDENTITY";

            int UserID = Convert.ToInt32(cmd.ExecuteScalar());

            closeConnection(conn); // To close Database

            return UserID;
        } // Create Account



    }
}