using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "edoho@gmail.com",
                FirstName = "Ken",
                LastName = "Edoho",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bey",
                        StreetLine2 = "Bey Ave",
                        Country = "Nigeria",
                        State = "Lagos",
                        City = "Lekki",
                        PostalCode = "303",
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Ring Road",
                        StreetLine2 = "Estate Gate",
                        Country = "Nigeria",
                        State = "Edo",
                        City = "Benin",
                        PostalCode = "222"
                    },
                }
            };
            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert

            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);

            for(int i = 0; i<1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
            }
        }
    }

}
            

            
            
        
