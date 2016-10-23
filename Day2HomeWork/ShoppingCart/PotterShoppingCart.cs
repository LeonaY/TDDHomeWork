using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class PotterShoppingCart
    {
        public int GetTotalPrice(IEnumerable<BookInfoModels> buyBooks)
        {
            return buyBooks.Sum(x => x.BookPrice);
        }
    }
}