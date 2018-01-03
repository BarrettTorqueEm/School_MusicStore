using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreB.Models
{
    public class Order
    {
        #region//Initializing Variables
        private int orderId = 0;
        private string orderDate = "N/A";
        private string userName = "N/A";
        private string firstName = "N/A";
        private string lastName = "N/A";
        private string address = "N/A";
        private string city = "N/A";
        private string state = "N/A";
        private string postalCode = "N/A";
        private string country = "N/A";
        private string phone = "N/A";
        private string email = "N/A";
        private int total = 0;
        #endregion

        #region//Gets and Sets
        public int OrderId
        {
            get
            {
                return this.orderId;
            }
            set
            {
                if (value > 0)
                {
                    this.orderId = value;
                }
            }
        }

        public string OrderDate
        {
            get
            {
                return this.orderDate;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.orderDate = null;
                }
                else
                {
                    this.orderDate = value;
                }
            }
        }

        public string UserName
        {
            get
            {
                return this.userName;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.userName = null;
                }
                else
                {
                    this.userName = value;
                }
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.firstName = null;
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.lastName = null;
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.address = null;
                }
                else
                {
                    this.address = value;
                }
            }
        }

        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.city = null;
                }
                else
                {
                    this.city = value;
                }
            }
        }

        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.state = null;
                }
                else
                {
                    this.state = value;
                }
            }
        }

        public string PostalCode
        {
            get
            {
                return this.postalCode;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.postalCode = null;
                }
                else
                {
                    this.postalCode = value;
                }
            }
        }

        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.country = null;
                }
                else
                {
                    this.country = value;
                }
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.phone = null;
                }
                else
                {
                    this.phone = value;
                }
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.email = null;
                }
                else
                {
                    this.email = value;
                }
            }
        }

        public int Total
        {
            get
            {
                return this.total;
            }
            set
            {
                if (value > 0)
                {
                    this.total = value;
                }
            }
        }
        #endregion

        #region//Constructors
        public Order() : this(0, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", 0)
        {

        }

        public Order(int anOrderId) : this(anOrderId, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", 0)
        {

        }

        public Order(int anOrderId, string anOrderDate) : this(anOrderId, anOrderDate, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", 0)
        {

        }

        public Order(int anOrderId, string anOrderDate, string aUserName) : this(anOrderId, anOrderDate, aUserName, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", 0)
        {

        }

        public Order(int anOrderId, string anOrderDate, string aUserName, string aFirstName) : this(anOrderId, anOrderDate, aUserName, aFirstName, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", 0)
        {

        }

        public Order(int anOrderId, string anOrderDate, string aUserName, string aFirstName, string aLastName) : this(anOrderId, anOrderDate, aUserName, aFirstName, aLastName, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", 0)
        {

        }

        public Order(int anOrderId, string anOrderDate, string aUserName, string aFirstName, string aLastName, string anAddress) : this(anOrderId, anOrderDate, aUserName, aFirstName, aLastName, anAddress, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", 0)
        {

        }

        public Order(int anOrderId, string anOrderDate, string aUserName, string aFirstName, string aLastName, string anAddress, string aCity) : this(anOrderId, anOrderDate, aUserName, aFirstName, aLastName, anAddress, aCity, "N/A", "N/A", "N/A", "N/A", "N/A", 0)
        {

        }

        public Order(int anOrderId, string anOrderDate, string aUserName, string aFirstName, string aLastName, string anAddress, string aCity, string aState) : this(anOrderId, anOrderDate, aUserName, aFirstName, aLastName, anAddress, aCity, aState, "N/A", "N/A", "N/A", "N/A", 0)
        {

        }

        public Order(int anOrderId, string anOrderDate, string aUserName, string aFirstName, string aLastName, string anAddress, string aCity, string aState, string aPostalCode) : this(anOrderId, anOrderDate, aUserName, aFirstName, aLastName, anAddress, aCity, aState, aPostalCode, "N/A", "N/A", "N/A", 0)
        {

        }

        public Order(int anOrderId, string anOrderDate, string aUserName, string aFirstName, string aLastName, string anAddress, string aCity, string aState, string aPostalCode, string aCountry) : this(anOrderId, anOrderDate, aUserName, aFirstName, aLastName, anAddress, aCity, aState, aPostalCode, aCountry, "N/A", "N/A", 0)
        {

        }

        public Order(int anOrderId, string anOrderDate, string aUserName, string aFirstName, string aLastName, string anAddress, string aCity, string aState, string aPostalCode, string aCountry, string aPhone) : this(anOrderId, anOrderDate, aUserName, aFirstName, aLastName, anAddress, aCity, aState, aPostalCode, aCountry, aPhone, "N/A" , 0)
        {

        }

        public Order(int anOrderId, string anOrderDate, string aUserName, string aFirstName, string aLastName, string anAddress, string aCity, string aState, string aPostalCode, string aCountry, string aPhone, string anEmail) :this(anOrderId, anOrderDate, aUserName, aFirstName, aLastName, anAddress, aCity, aState, aPostalCode, aCountry, aPhone, anEmail, 0)
        {
           
        }

        public Order(int anOrderId, string anOrderDate, string aUserName, string aFirstName, string aLastName, string anAddress, string aCity, string aState, string aPostalCode, string aCountry, string aPhone, string anEmail, int aTotal)
        {
            this.OrderId = anOrderId;
            this.OrderDate = anOrderDate;
            this.UserName = aUserName;
            this.FirstName = aFirstName;
            this.LastName = aLastName;
            this.Address = anAddress;
            this.City = aCity;
            this.State = aState;
            this.PostalCode = aPostalCode;
            this.Country = aCountry;
            this.Phone = aPhone;
            this.Email = anEmail;
            this.Total = aTotal;
        }  
        #endregion

        //ToString method
        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + "Order Id: " + OrderId + "\n";
            aMessage = aMessage + "Order Date: " + OrderDate + "\n";
            aMessage = aMessage + "Username: " + UserName + "\n";
            aMessage = aMessage + "First Name: " + FirstName + "\n";
            aMessage = aMessage + "Last Name: " + LastName + "\n";
            aMessage = aMessage + "Address: " + Address + "\n";
            aMessage = aMessage + "City: " + City + "\n";
            aMessage = aMessage + "State: " + State + "\n";
            aMessage = aMessage + "Postal Code: " + PostalCode + "\n";
            aMessage = aMessage + "Country: " + Country + "\n";
            aMessage = aMessage + "Phone: " + Phone + "\n";
            aMessage = aMessage + "Email: " + Email + "\n";
            aMessage = aMessage + "Total: " + Total + "\n";
            return aMessage;
        }
    }
}