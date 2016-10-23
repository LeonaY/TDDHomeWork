using System;
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

        [TestMethod]
        public void GetTotalPrice_BuyHarryPotter_FirstAndSecondAndThirdEpisode()
        {
            //arrange
            var expected = 270;
            var potterShoppingCart = new PotterShoppingCart();
            var buyBooks = SetBuyThirdBook();

            //act
            var actual = potterShoppingCart.GetTotalPrice(buyBooks);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTotalPrice_BuyHarryPotter_First_Second_Third_FourthEpisode()
        {
            //arrange
            var expected = 320;
            var potterShoppingCart = new PotterShoppingCart();
            var buyBooks = SetBuyFourBook();

            //act
            var actual = potterShoppingCart.GetTotalPrice(buyBooks);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTotalPrice_BuyHarryPotter_First_Second_Third_Fourth_FifthEpisode()
        {
            //arrange
            var expected = 375;
            var potterShoppingCart = new PotterShoppingCart();
            var buyBooks = SetBuyFourBook();

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
        private IEnumerable<BookInfoModels> SetBuyThirdBook()
        {
            var books = new List<BookInfoModels> {
                new BookInfoModels { BookID = "001", BookPrice = 100},
                new BookInfoModels { BookID = "002", BookPrice = 100},
                new BookInfoModels { BookID = "003", BookPrice = 100}
            };
            return books;
        }
        private IEnumerable<BookInfoModels> SetBuyFourBook()
        {
            var books = new List<BookInfoModels> {
                new BookInfoModels { BookID = "001", BookPrice = 100},
                new BookInfoModels { BookID = "002", BookPrice = 100},
                new BookInfoModels { BookID = "003", BookPrice = 100},
                new BookInfoModels { BookID = "004", BookPrice = 100}
            };
            return books;
        }
    }
}
