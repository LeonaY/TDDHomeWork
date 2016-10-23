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
            var buyBooks = SetBuyTwoDifferentTwoSameeBook();

            //act
            var actual = potterShoppingCart.GetTotalPrice(buyBooks);

            //assert
            Assert.AreEqual(expected, actual);
        }

        private IEnumerable<PotterBookInfoModels> SetBuyBook()
        {
            var books = new List<PotterBookInfoModels> {
                new PotterBookInfoModels { BookID = "001"}
            };
            return books;
        }
        private IEnumerable<PotterBookInfoModels> SetBuyTwoBook()
        {
            var books = new List<PotterBookInfoModels> {
                new PotterBookInfoModels { BookID = "001"},
                new PotterBookInfoModels { BookID = "002"}
            };
            return books;
        }
        private IEnumerable<PotterBookInfoModels> SetBuyThirdBook()
        {
            var books = new List<PotterBookInfoModels> {
                new PotterBookInfoModels { BookID = "001"},
                new PotterBookInfoModels { BookID = "002"},
                new PotterBookInfoModels { BookID = "003"}
            };
            return books;
        }
        private IEnumerable<PotterBookInfoModels> SetBuyFourBook()
        {
            var books = new List<PotterBookInfoModels> {
                new PotterBookInfoModels { BookID = "001"},
                new PotterBookInfoModels { BookID = "002"},
                new PotterBookInfoModels { BookID = "003"},
                new PotterBookInfoModels { BookID = "004"}
            };
            return books;
        }
        private IEnumerable<PotterBookInfoModels> SetBuyFiveBook()
        {
            var books = new List<PotterBookInfoModels> {
                new PotterBookInfoModels { BookID = "001"},
                new PotterBookInfoModels { BookID = "002"},
                new PotterBookInfoModels { BookID = "003"},
                new PotterBookInfoModels { BookID = "004"},
                new PotterBookInfoModels { BookID = "005"}
            };
            return books;
        }
        private IEnumerable<PotterBookInfoModels> SetBuyTwoDifferentTwoSameeBook()
        {
            var books = new List<PotterBookInfoModels> {
                new PotterBookInfoModels { BookID = "001"},
                new PotterBookInfoModels { BookID = "002"},
                new PotterBookInfoModels { BookID = "003"},
                new PotterBookInfoModels { BookID = "003"}
            };
            return books;
        }
        
    }
}
