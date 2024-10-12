using System;



    // Define the Word class
    public class Customer
    {
        private string _custName;
        private Address _custAddress;


        public Customer()
        {

        }


        public bool IsUSACustomer()
        {
            return _custAddress.IsUSAaddress(_custAddress.GetCountry());
        }

        public void SetCustomerName(string name)
        {
            _custName = name;
        }

        public string GetCustomerName()
        {
            return _custName;
        }

        public void SetCustomerAddress(string street, string city, string state, string country)
        {
            _custAddress = new(street: street, city: city, state: state, country: country);
        }

        public Address GetAddress()
        {
            return _custAddress;
        }
    }