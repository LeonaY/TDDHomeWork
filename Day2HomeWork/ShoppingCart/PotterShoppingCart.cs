using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class PotterShoppingCart
    {
        public int GetTotalPrice(IEnumerable<BookInfoModels> buyBooks)
        {
            var result = 0;          

            result = Convert.ToInt16(buyBooks.Sum(x => x.BookPrice) * (1 - GetDiscount(buyBooks)));
            return result;
        }

        private double GetDiscount(IEnumerable<BookInfoModels> buyBooks)
        {
            double result = 0;
            var differentBookCount = buyBooks.Select(x => x.BookID).Distinct().Count();
                        
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