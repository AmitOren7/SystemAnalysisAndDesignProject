using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysisAndDesignProject
{
    public abstract class Employee
    {
        protected string firstName;
        protected string lastName;
        protected string id;
        protected string phoneNumber;
        protected string email;
        protected string address;
        protected string userName;
        protected string password;
        protected string idCopy;


        public Employee(string firstName, string lastName, string id, string phoneNumber,
           string email, string address, string userName, string password,
           string idCopy)
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
          

        }
        public abstract void Create();


        public abstract void Update();

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

        public string GetIdCopy()
        {
            return this.idCopy;
        }

        public string GetName()
        {
            string fullName = this.firstName + " " + this.lastName;
            return fullName;
        }
    }
}

