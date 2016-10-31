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
            var buyBooks = new List<PotterBookInfoModels> {
                new PotterBookInfoModels { BookID = "001"}
            };

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
            var buyBooks = new List<PotterBookInfoModels> {
                new PotterBookInfoModels { BookID = "001"},
                new PotterBookInfoModels { BookID = "002"}
            };

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
            var buyBooks = new List<PotterBookInfoModels> {
                new PotterBookInfoModels { BookID = "001"},
                new PotterBookInfoModels { BookID = "002"},
                new PotterBookInfoModels { BookID = "003"}
            };

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
            var buyBooks = new List<PotterBookInfoModels> {
                new PotterBookInfoModels { BookID = "001"},
                new PotterBookInfoModels { BookID = "002"},
                new PotterBookInfoModels { BookID = "003"},
                new PotterBookInfoModels { BookID = "004"}
            };

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
            var buyBooks = new List<PotterBookInfoModels> {
                new PotterBookInfoModels { BookID = "001"},
                new PotterBookInfoModels { BookID = "002"},
                new PotterBookInfoModels { BookID = "003"},
                new PotterBookInfoModels { BookID = "004"},
                new PotterBookInfoModels { BookID = "005"}
            };

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
            var buyBooks = new List<PotterBookInfoModels> {
                new PotterBookInfoModels { BookID = "001"},
                new PotterBookInfoModels { BookID = "002"},
                new PotterBookInfoModels { BookID = "003"},
                new PotterBookInfoModels { BookID = "003"}
            };

            //act
            var actual = potterShoppingCart.GetTotalPrice(buyBooks);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTotalPriceTest_第一集買了一本第二三集各買了兩本_should_be_460()
        {
            //arrange
            var expected = 460;
            var potterShoppingCart = new PotterShoppingCart();
            var buyBooks = new List<PotterBookInfoModels> {
                new PotterBookInfoModels { BookID = "001"},
                new PotterBookInfoModels { BookID = "002"},
                new PotterBookInfoModels { BookID = "002"},
                new PotterBookInfoModels { BookID = "003"},
                new PotterBookInfoModels { BookID = "003"}
            };

            //act
            var actual = potterShoppingCart.GetTotalPrice(buyBooks);

            //assert
            Assert.AreEqual(expected, actual);
        }
        

    }
}
