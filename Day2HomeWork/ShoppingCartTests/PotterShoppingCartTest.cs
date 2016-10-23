﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;
using System.Collections.Generic;

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
            var potterShoppingCart = new PotterShoppingCart();
            var buyBooks = SetBuyBook();
                
            //act
            var actual = potterShoppingCart.GetTotalPrice(buyBooks);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTotalPrice_BuyHarryPotter_FirstAndSecondEpisode()
        {
            //arrange
            var expected = 190;
            var potterShoppingCart = new PotterShoppingCart();
            var buyBooks = SetBuyTwoBook();

            //act
            var actual = potterShoppingCart.GetTotalPrice(buyBooks);

            //assert
            Assert.AreEqual(expected, actual);
        }

        private IEnumerable<BookInfoModels> SetBuyBook()
        {
            var books = new List<BookInfoModels> {
                new BookInfoModels { BookID = "001", BookPrice = 100}
            };
            return books;
        }
        private IEnumerable<BookInfoModels> SetBuyTwoBook()
        {
            var books = new List<BookInfoModels> {
                new BookInfoModels { BookID = "001", BookPrice = 100},
                new BookInfoModels { BookID = "002", BookPrice = 100}
            };
            return books;
        }
    }
}