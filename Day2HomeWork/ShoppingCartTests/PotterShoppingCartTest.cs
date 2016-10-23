using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;

namespace ShoppingCartTests
{
    [TestClass]
    public class PotterShoppingCartTest
    {
        [TestMethod]
        public void GetTotalPrice_BuyHarryPotter_FirstEpisode()
        {
            //arrange
            var expected = 100;
            PotterShoppingCart potterShoppingCart = new PotterShoppingCart();

            //act
            var actual = potterShoppingCart.GetTotalPrice();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
