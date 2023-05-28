using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {

            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Ken",
                LastName = "Edoho"
            };


            string expected = "Edoho, Ken";

            //Act
            string actual = customer.FullName;   //Perform the operation we are testing.


            //Assert
            Assert.AreEqual(expected, actual);   //Verify the expected value equals the actual value.

        }

        //Handling Invalid Value.
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange

            Customer customer = new Customer
            {
                LastName = "Edoho"
            };
            string expected = "Edoho";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual (expected, actual);

        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange

            Customer customer = new Customer
            {
                FirstName = "Ken"
            };
            string expected = "Ken";

            //Act
            string actual = customer.FullName;
            //Assert
            Assert.AreEqual(expected, actual);


        }
        
        
    }   
}
