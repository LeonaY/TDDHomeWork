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
        public void GetTotalPriceTest_第一集買了一本其他都沒買_should_be_100()
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
        public void GetTotalPriceTest_第一集買了一本第二集也買了一本_should_be_190()
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
        public void GetTotalPriceTest_一二三集各買了一本_should_be_270()
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
        public void GetTotalPriceTest_一二三四集各買了一本_should_be_320()
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
        public void GetTotalPriceTest_一次買了整套一二三四五集各買了一本_should_be_375()
        {
            //arrange
            var expected = 375;
            var potterShoppingCart = new PotterShoppingCart();
            var buyBooks = SetBuyFiveBook();

            //act
            var actual = potterShoppingCart.GetTotalPrice(buyBooks);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTotalPriceTest_一二集各買了一本第三集買了兩本_should_be_370()
        {
            //arrange
            var expected = 370;
            var potterShoppingCart = new PotterShoppingCart();
            var buyBooks = SetBuyFiveBook();

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
        private IEnumerable<BookInfoModels> SetBuyFiveBook()
        {
            var books = new List<BookInfoModels> {
                new BookInfoModels { BookID = "001", BookPrice = 100},
                new BookInfoModels { BookID = "002", BookPrice = 100},
                new BookInfoModels { BookID = "003", BookPrice = 100},
                new BookInfoModels { BookID = "004", BookPrice = 100},
                new BookInfoModels { BookID = "005", BookPrice = 100}
            };
            return books;
        }
        private IEnumerable<BookInfoModels> SetBuyTwoDifferentTwoSameeBook()
        {
            var books = new List<BookInfoModels> {
                new BookInfoModels { BookID = "001", BookPrice = 100},
                new BookInfoModels { BookID = "002", BookPrice = 100},
                new BookInfoModels { BookID = "003", BookPrice = 100},
                new BookInfoModels { BookID = "003", BookPrice = 100}
            };
            return books;
        }
        
    }
}
