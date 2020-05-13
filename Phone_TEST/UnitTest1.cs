using System;
using Kianwaters_s00187504;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Phone_TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IncreasePrice()
        {
            //Ex4
            //Arrange
            Phone phone = new Phone();
            double expectedPrice = 500;

            //Act
            //Declaring the start price and the percentage value
            phone.IncreasePrice(500, 10);

            //Assert
            Assert.AreEqual(expectedPrice, phone.Price);
        }
    }
}
