using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


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
                LastName = "Edoho"

            };

            
            //--Act
            var actual = customerRepository.Retrieve(1);
            
            //--Assert
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }
    }
}
