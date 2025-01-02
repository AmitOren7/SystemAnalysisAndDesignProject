using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysisAndDesignProject
{
    public class Driver
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
        private string licenseCopy; //path of license file
        private string licenseId; //serial number of license


        public Driver(string firstName, string lastName, string id, string phoneNumber,
            string email, string address, string userName, string password,
            string idCopy, string licenseCopy, string licenseId)
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
            this.licenseCopy = licenseCopy;
            this.licenseId = licenseId;


            this.createDriver();
            Program.DriverList.Add(this);
        }

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

        // updating the license file path
        public bool UpdateLicenseCopy(string licenseCopy)
        {
            this.licenseCopy = licenseCopy;
            return true;
        }

        //public bool UpdateOrederStatus(string orederStatus) 


        //public void FillWorkCertification() { }





    }
}
