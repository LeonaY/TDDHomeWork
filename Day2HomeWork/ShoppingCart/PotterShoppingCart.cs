using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class PotterShoppingCart
    {
        private Dictionary<int, double> rate;

        public PotterShoppingCart()
        {
            this.rate = new Dictionary<int, double> {
                { 1, 1},
                { 2, 0.95},
                { 3, 0.9},
                { 4, 0.8},
                { 5, 0.75}
            };
        }

        public int GetTotalPrice(IEnumerable<PotterBookInfoModels> buyBooks)
        {
            //將書本做Group {集數,售價,購買數量} EX:{"第一集",100元,3本}、{"第二集",100元,1本}
            var groupBooks = from x in buyBooks
                             group x by x.BookID into g
                             let count = g.Count()
                             orderby count descending
                             select new { BookID = g.First().BookID, BookPrice = g.First().BookPrice, Count = count  };

            var totalPrice = 0;            
            for (int i = 1; i <= groupBooks.Max(x => x.Count); i++)
            {
                //取得折扣group，EX: [{第一集},{第二集}]、[{第一集}]
                var distinctBook = groupBooks.Where(x => x.Count - i >= 0);
                totalPrice += Convert.ToInt32(distinctBook.Sum(x => x.BookPrice) * rate[distinctBook.Count()]);
            }
            return totalPrice;
        }
        
    }
}