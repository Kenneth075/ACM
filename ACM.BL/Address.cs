using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }


        public int AddressId { get;private set; }
        public int AddressType { get; set; }
        public string Country { get; set; } 
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string StreetLine1 { get;set; }
        public string StreetLine2 { get;set; }  

        //Validate the address data
        public bool Validate()
        {
            var IsValid = true;
            
            if(PostalCode==null) IsValid=false;

            return IsValid;
        }
        //Retrieve data
        public Address Retrieve(int AddressId)
        {
            return new Address();
        }

        //Save
        public bool Save()
        {
            return true;
        }

       


    }
}
