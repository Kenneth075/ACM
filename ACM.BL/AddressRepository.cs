using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int AddressId)   //Retrieving a single customer address.
        {
            Address address = new Address();

            if (AddressId == 1)            //Retrieving for a single address.
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bey";
                address.StreetLine2 = "Bey Ave";
                address.Country = "Nigeria";
                address.State = "Lagos";
                address.City = "Lekki";
                address.PostalCode = "303";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var Addresslist=new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bey",
                StreetLine2 = "Bey Ave",
                Country = "Nigeria",
                State = "Lagos",
                City = "Lekki",
                PostalCode = "303",
            };
            Addresslist.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Ring Road",
                StreetLine2 = "Estate Gate",
                Country = "Nigeria",
                State = "Edo",
                City = "Benin",
                PostalCode = "222"
            };
            Addresslist.Add(address);
            
            return Addresslist;
        }
        public bool Save(Address address)
        {
            return true;
        }
    }
}
