using projHerrons_Website.App_Code.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace projHerrons_Website.App_Code.DAL
{
    public class DataAccess
    {
        // Opening Connection to Database
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

        // Closing Connection to Database
        public static void closeConnection(OleDbConnection cn)
        {
            cn.Close();
        } // Close Connection

        // Inserting Account Data into Database
        public static int createAccount(String Firstname, String Lastname, String Email, String Password, String Status)
        {
            OleDbConnection conn = openConnection(); // Communicate With Database

            String sqlStr = "INSERT into tblAccounts(FirstName, LastName, Email, [Password], Status)" +
                "VALUES('"+ Firstname + "', '" + Lastname + "', '" + Email + "', '" + Password + "', '" + Status + "')";

            OleDbCommand cmd = new OleDbCommand(sqlStr, conn); 

            cmd.ExecuteNonQuery(); // Non Query For Insert, Update, Delete. Anything else would be Scalar e.g. Get Information 

            cmd.CommandText = "SELECT @@IDENTITY";

            int UserID = Convert.ToInt32(cmd.ExecuteScalar());

            closeConnection(conn); // To close Database

            return UserID;
        } // Create Account

        // Using the Pink Route
        // Getting all Accounts
        public static DataSet getAllAccounts()
        {
            DataSet ds = new DataSet();

            OleDbConnection conn = openConnection();
            String sqlStr = "SELECT * FROM tblAccounts";

            OleDbDataAdapter daAccounts = new OleDbDataAdapter(sqlStr, conn); // OleDbDataAdapter is containing a command object.

            daAccounts.Fill(ds, "dtAccounts"); // Fill is Select
            closeConnection(conn);

            return ds;
        }

        // Getting a Single Account From Database
        public static Account getAccount(int id)
        {
            Account obj = new Account();

            OleDbConnection conn = openConnection();
            String sqlStr = "SELECT UserID, FirstName, LastName, Email, Password, Status FROM tblAccounts" +
                " WHERE UserID=" + id;

            OleDbCommand cmd = new OleDbCommand(sqlStr, conn);

            //Execute reader for Generate Reader - On diagram
            OleDbDataReader reader = cmd.ExecuteReader(); // Reads one record at a time

            while (reader.Read())
            {
                obj.setUserID(Convert.ToInt32(reader["UserID"]));
                obj.setFirstName(reader["FirstName"].ToString());
                obj.setLastName(reader["LastName"].ToString());
                obj.setEmail(reader["Email"].ToString());
                obj.setPassword(reader["Password"].ToString());
                obj.setStatus(reader["Status"].ToString());
            }

            reader.Close();
            closeConnection(conn);

            return obj;
        } // getAccount

        // Updating a User Information
        public static bool updateAccount(int UserID, String Firstname, String Lastname, String Email, String Password, String Status)
        {
            OleDbConnection conn = openConnection();

            String sqlStr = "UPDATE tblAccounts SET [FirstName] = '" + Firstname + "', [LastName] = '" + Lastname +
                "', [Email] = '" + Email + "', [Password] = '" + Password + "', [Status] = '" + Status + "' WHERE UserID = " + UserID;

            OleDbCommand cmd = new OleDbCommand(sqlStr, conn);

            int count = cmd.ExecuteNonQuery();

            closeConnection(conn);

            if(count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Remove an Account from Datbase
        public static bool removeAccount(int id)
        {
            OleDbConnection conn = openConnection();

            String sqlStr = "DELETE FROM tblAccounts WHERE UserID =" + id;

            OleDbCommand cmd = new OleDbCommand(sqlStr, conn);

            int count = cmd.ExecuteNonQuery();

            closeConnection(conn );
            if(count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Checking that the Username and Password are both valid in Databaes
        public static int validateLogin(string email, string pwd)
        {
            int userID = -1;

            try
            {
                OleDbConnection con = openConnection();
                //string strSQL = "SELECT UserID FROM tblAccounts WHERE " +
                //    "'[UserEmail] = '" + email + "', [UserPassword] = '" + pwd;

                //"(((Email) ='" + email + "') AND ((tblAccount.Password) ='" + pwd + "'))";

                string strSQL = "SELECT tblAccounts.UserID FROM tblAccounts WHERE " +
                                    "(((tblAccounts.Email) ='" + email + "') AND ((tblAccounts.Password) ='" + pwd + "'))";

                OleDbCommand cmd = new OleDbCommand(strSQL, con);

                OleDbDataReader reader = cmd.ExecuteReader();

                reader.Read();
                userID = Convert.ToInt32(reader["UserID"]);
                closeConnection(con);
                reader.Close();
            }
            catch (Exception ex)
            {


            }
            return userID;
        }




        // Checking the Email doesn't already exist in Database
        public static int validEmail(String email)
        {
            int userID = -1;

            try
            {
                OleDbConnection con = openConnection();
                //string strSQL = "SELECT UserID FROM tblAccounts WHERE " +
                //    "'[UserEmail] = '" + email + "', [UserPassword] = '" + pwd;

                //"(((Email) ='" + email + "') AND ((tblAccount.Password) ='" + pwd + "'))";

                string strSQL = "SELECT tblAccounts.UserID FROM tblAccounts WHERE " +
                                    "(((tblAccounts.Email) ='" + email + "'))";

                OleDbCommand cmd = new OleDbCommand(strSQL, con);

                OleDbDataReader reader = cmd.ExecuteReader();

                reader.Read();
                userID = Convert.ToInt32(reader["UserID"]);
                closeConnection(con);
                reader.Close();
            }
            catch (Exception ex)
            {


            }
            System.Diagnostics.Debug.WriteLine("The user ID::::: " + userID);
            return userID;

        } // getAccount



    }
}