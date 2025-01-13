using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysisAndDesignProject
{
    public class OperationalManager
    {
        private string firstName;
        private string lastName;
        private string id;
        private string phoneNumber;
        private string email;
        private string address;
        private string userName;
        private string password;
        private string idCopy; //path of id file
        private Role role;



        public OperationalManager(string firstName, string lastName, string id, string phoneNumber,
               string email, string address, string userName, string password,
               string idCopy, bool is_new, Role role)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.address = address;
            this.userName = userName;
            this.password = password;
            this.idCopy = idCopy;
            this.role = role;
            //if (is_new)
            //{
            //    this.CreateOperationalManager();
            //    Program.OperationalManagerList.Add(this);
            //}

        }

        //public void CreateOperationalManager()
        //{
        //    SqlCommand sp = new SqlCommand();
        //    sp.CommandText = "EXECUTE dbo.sp_add_operationalManager @firstName, @lastName, @id, @phoneNumber" +
        //        ", @email, @address, @userName, @password, @idCopy, @role";
        //    sp.Parameters.AddWithValue("@firstName", this.firstName);
        //    sp.Parameters.AddWithValue("@lastName", this.lastName);
        //    sp.Parameters.AddWithValue("@id", this.id);
        //    sp.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
        //    sp.Parameters.AddWithValue("@email", this.email);
        //    sp.Parameters.AddWithValue("@address", this.address);
        //    sp.Parameters.AddWithValue("@userName", this.userName);
        //    sp.Parameters.AddWithValue("@password", this.password);
        //    sp.Parameters.AddWithValue("@idCopy", this.idCopy);
        //    sp.Parameters.AddWithValue("@role", this.role);

        //    SQL_CON SC = new SQL_CON();
        //    SC.execute_non_query(sp);
        //}


        public string GetFirstName()
        {
            return this.firstName;
        }
        public string GetLastName()
        {
            return this.lastName;
        }
        public string GetId()
        {
            return this.id;
        }
        public string GetPhoneNumber()
        {

            return this.phoneNumber;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public string GetAddress()
        {
            return this.address;
        }

        public string GetUserName()
        {
            return this.userName;
        }

        public string GetPassword()
        {
            return this.password;
        }


        public bool UpdatePassword(string password)
        {
            this.password = password;
            return true;
        }

        public bool UpdatePhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
            return true;
        }

        public bool UpdateAddress(string address)
        {
            this.address = address;
            return true;
        }

        public Role GetRole()
        {
            return this.role;
        }
        
        
    }
}

