using Microsoft.SqlServer.Server;
using projHerrons_Website.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace projHerrons_Website.App_Code.BLL
{
    public class Account
    {
        private int UserID;
        private String Firstname;
        private String Lastname;
        private String Email;
        private String Password;
        private String Status;


        // Update Account Information 
        public void updateAccount()
        {
            DataAccess.updateAccount(this.UserID, this.Firstname, this.Lastname, this.Email, this.Password, this.Status);
        }

        // Delete Account Information
        public bool deleteAccount()
        {
            return DataAccess.removeAccount(this.UserID);
        }

        // Populates a Account Object
        public void loadAccount(int UserID)
        {
            // Using a Temporary Account Object to populate Data Fields
            Account tmpAccountObj = DataAccess.getAccount(UserID);
            this.UserID = tmpAccountObj.getUserID();
            this.Firstname = tmpAccountObj.getFirstName();
            this.Lastname = tmpAccountObj.getLastName();
            this.Email = tmpAccountObj.getEmail();
            this.Password = tmpAccountObj.getPassword();
            this.Status = tmpAccountObj.getStatus();

        }

        public Account()
        {

        }

        public Account(String email, String password)
        {
            this.Email = email;
            this.Password = password;
        }

        public int validateLogin()
        {
            int id = DataAccess.validateLogin(Email, Password);
            return id;
        }

        // Setters

        //ID
        public void setUserID(int UserID)
        {
            this.UserID = UserID;
        }

        //First Name
        public void setFirstName(String Firstname)
        {
            this.Firstname = Firstname;
        }

        //Last Name
        public void setLastName(String Lastname)
        {
            this.Lastname = Lastname;
        }

        //Email
        public void setEmail(String Email)
        {
            this.Email = Email;
        }

        //Password
        public void setPassword(String Password)
        {
            this.Password = Password;
        }

        //Status
        public void setStatus(String Status)
        {
            this.Status = Status;
        }

        



        // Getters

        // ID
        public int getUserID()
        {
            return this.UserID;
        }
        
        // First Name
        public String getFirstName()
        {
            return this.Firstname;
        }
        
        // Last Name
        public String getLastName()
        {
            return this.Lastname;
        }

        // Email
        public String getEmail()
        {
            return this.Email;
        }

        // Password
        public String getPassword()
        {
            return this.Password;
        }

        // Status 
        public String getStatus()
        {
            return this.Status;
        }


        


        // Create New Account User
        public void createNewAccount()
        {
            this.UserID = DataAccess.createAccount(this.Firstname, this.Lastname, this.Email, this.Password, this.Status);
        }


    }
}