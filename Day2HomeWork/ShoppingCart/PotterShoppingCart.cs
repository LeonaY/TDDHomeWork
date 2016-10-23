using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class PotterShoppingCart
    {
        public int GetTotalPrice(IEnumerable<BookInfoModels> buyBooks)
        {
            double discount = 0;
            var result = 0;

            if (buyBooks.Select(x => x.BookID).Distinct().Count() == 2)
            {
                discount = 0.05;
            }
            else if (buyBooks.Select(x => x.BookID).Distinct().Count() == 3)
            {
                discount = 0.1;
            }

            result = Convert.ToInt16(buyBooks.Sum(x => x.BookPrice) * (1 - discount));
            return result;
        }
    }
}