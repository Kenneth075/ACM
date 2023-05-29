using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTests
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //--Arrange
            var productRepository = new ProductRepository();
            var experted = new Product(2)
            {
                ProductName = "Sunflower",
                ProductDescription = "Sunflower Big Size",
                CurrentPrice = 15.96M,
            };


            //Act
            var actual = productRepository.Retrieve(2);


            //Assert
            Assert.AreEqual(experted.ProductName, actual.ProductName);
            Assert.AreEqual(experted.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(experted.CurrentPrice, actual.CurrentPrice);

        }
    }
}
