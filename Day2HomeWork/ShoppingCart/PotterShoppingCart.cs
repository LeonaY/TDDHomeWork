using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class PotterShoppingCart
    {
        public int GetTotalPrice(IEnumerable<PotterBookInfoModels> buyBooks)
        {
            var totalPrice = 0;
            var distinctItems = from x in buyBooks
                       group x by x.BookID into g
                       let count = g.Count()
                       orderby count descending
                       select new { BookID = g.First().BookID, BookPrice = g.First().BookPrice, Count = count  };
            var maxloop = distinctItems.Max(x => x.Count);

            for (int i = 0; i < maxloop; i++)
            {
                var differentBookCount = distinctItems.Where(x => x.Count > 0).Count();
                var discount = GetDiscount(differentBookCount);
                totalPrice += Convert.ToInt16(distinctItems.Where(x => x.Count > 0).Sum(x => x.BookPrice) * ( 1- discount));
                distinctItems = distinctItems.Select(x => new { BookID = x.BookID, BookPrice = x.BookPrice, Count = x.Count - 1   });
            }
            return totalPrice;
        }

        private double GetDiscount(int differentBookCount)
        {
            double result = 0;
            //key放判斷優惠的本數，value放折扣
            Dictionary<int, double> discountConditions = new Dictionary<int, double>();
            discountConditions.Add(2, 0.05);
            discountConditions.Add(3, 0.1);
            discountConditions.Add(4, 0.2);
            discountConditions.Add(5, 0.25);

            result = discountConditions.ContainsKey(differentBookCount) 
                     ? discountConditions[differentBookCount]
                     : 0;

            return result;
        }
    }
}