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
        
        public void GetSumOfGroupByCol_取得Cost的總和()
        {
            var expected = new int[] { 6, 15, 24, 21 };

            Calculator calculator = new Calculator();
            IEnumerable<ProductModel> sourceList = GetSourctList();
            List<int> actual = calculator.GetSumOfGroupByCol<ProductModel>(3, "Cost", sourceList);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSumOfGroupByCol_取得Revenue的總和()
        {
            var expected = new int[] { 50, 66, 60 };

            Calculator calculator = new Calculator();
            IEnumerable<ProductModel> sourceList = GetSourctList();
            List<int> actual = calculator.GetSumOfGroupByCol<ProductModel>(4, "Revenue", sourceList);

            CollectionAssert.AreEqual(expected, actual);
        }

        private List<ProductModel> GetSourctList()
        {
            List<ProductModel> model = new List<ProductModel>();
            for (int i = 1; i <= 11; i++)
            {
                model.Add(new ProductModel { ID = i, Cost = i, Revenue = 10 + i, SellPrice = 20 + i });
            }
            return model;
        }
    }
}
