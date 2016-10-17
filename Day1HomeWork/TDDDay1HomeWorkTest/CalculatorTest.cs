using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDDay1HomeWork;
using System.Collections.Generic;

namespace TDDDay1HomeWorkTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        
        public void GetSumOfGroupByCol_有11筆資料3筆一組取Cost總和()
        {
            var expected = new int[] { 6, 15, 24, 21 };

            Calculator calculator = new Calculator();
            var sourceList = GetSourctList();
            var actual = calculator.GetSumOfGroupByCol<ProductModel>(3, "Cost", sourceList);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSumOfGroupByCol_有11筆資料4筆一組取Revenue總和()
        {
            var expected = new int[] { 50, 66, 60 };

            Calculator calculator = new Calculator();
            var sourceList = GetSourctList();
            var actual = calculator.GetSumOfGroupByCol<ProductModel>(4, "Revenue", sourceList);

            CollectionAssert.AreEqual(expected, actual);
        }

        private List<ProductModel> GetSourctList()
        {
            var model = new List<ProductModel>
            {
                new ProductModel { ID = 1, Cost = 1, Revenue = 11, SellPrice = 21},
                new ProductModel { ID = 2, Cost = 2, Revenue = 12, SellPrice = 22},
                new ProductModel { ID = 3, Cost = 3, Revenue = 13, SellPrice = 23},
                new ProductModel { ID = 4, Cost = 4, Revenue = 14, SellPrice = 24},
                new ProductModel { ID = 5, Cost = 5, Revenue = 15, SellPrice = 25},
                new ProductModel { ID = 6, Cost = 6, Revenue = 16, SellPrice = 26},
                new ProductModel { ID = 7, Cost = 7, Revenue = 17, SellPrice = 27},
                new ProductModel { ID = 8, Cost = 8, Revenue = 18, SellPrice = 28},
                new ProductModel { ID = 9, Cost = 9, Revenue = 19, SellPrice = 29},
                new ProductModel { ID = 10, Cost = 10, Revenue = 20, SellPrice = 30},
                new ProductModel { ID = 11, Cost = 11, Revenue = 21, SellPrice = 31},
            };
            return model;
        }
    }
}
