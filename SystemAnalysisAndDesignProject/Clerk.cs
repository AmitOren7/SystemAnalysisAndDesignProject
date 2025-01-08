using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysisAndDesignProject
{
    public class Clerk
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
            private PerformanceStatus performanceStatus;

        public Clerk(string firstName, string lastName, string id, string phoneNumber,
           string email, string address, string userName, string password,
           string idCopy, bool is_new, Role role, PerformanceStatus performanceStatus)
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
            this.performanceStatus = performanceStatus;
            if (is_new)
            {
                this.CreateClerk();
                Program.ClerkList.Add(this);
            }

        }

        public void CreateClerk()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_add_Driver @firstName, @lastName, @id, @phoneNumber" +
                ", @email, @address, @userName, @password, @idCopy, @licenseCopy, @licenseId, @role, @performanceStatus";
            sp.Parameters.AddWithValue("@firstName", this.firstName);
            sp.Parameters.AddWithValue("@lastName", this.lastName);
            sp.Parameters.AddWithValue("@id", this.id);
            sp.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            sp.Parameters.AddWithValue("@email", this.email);
            sp.Parameters.AddWithValue("@address", this.address);
            sp.Parameters.AddWithValue("@userName", this.userName);
            sp.Parameters.AddWithValue("@password", this.password);
            sp.Parameters.AddWithValue("@idCopy", this.idCopy);
            sp.Parameters.AddWithValue("@role", this.role);
            sp.Parameters.AddWithValue("@performanceStatus", this.performanceStatus);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp);
        }

        // Getter and Setter for firstName
        public string GetFirstName()
        {
            return this.firstName;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        // Getter and Setter for lastName
        public string GetLastName()
        {
            return this.lastName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        // Getter and Setter for id
        public string GetId()
        {
            return this.id;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        // Getter and Setter for phoneNumber
        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        // Getter and Setter for email
        public string GetEmail()
        {
            return this.email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        // Getter and Setter for address
        public string GetAddress()
        {
            return this.address;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        // Getter and Setter for userName
        public string GetUserName()
        {
            return this.userName;
        }

        public void SetUserName(string userName)
        {
            this.userName = userName;
        }

        // Getter and Setter for password
        public string GetPassword()
        {
            return this.password;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }

        // Getter and Setter for idCopy
        public string GetIdCopy()
        {
            return this.idCopy;
        }

        public void SetIdCopy(string idCopy)
        {
            this.idCopy = idCopy;
        }

        // Getter and Setter for role
        public Role GetRole()
        {
            return this.role;
        }

        public void SetRole(Role role)
        {
            this.role = role;
        }

        // Getter and Setter for 'performanceStatus'
        public PerformanceStatus GetPerformanceStatus()
        {
            return this.performanceStatus;
        }

        public void SetPerformanceStatus(PerformanceStatus performanceStatus)
        {
            this.performanceStatus = performanceStatus;
        }

    }
    
}
