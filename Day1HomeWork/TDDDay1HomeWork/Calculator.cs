using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TDDDay1HomeWork
{
    public class Calculator
    {
        /// <summary>
        ///取得群祖集合的群祖加總
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="groupOfNum">幾個為一組</param>
        /// <param name="columnName">計算欄位</param>
        /// <param name="sourceList">計算清單</param>
        /// <returns></returns>
        public List<int> GetSumOfGroupByCol<T>(int groupOfNum, string columnName, IEnumerable<T> sources)
        {
            List<int> result = new List<int>();
            int currentIndex = 0;
            int sum = 0;
            Type type = typeof(T);
            PropertyInfo info = type.GetProperty(columnName);

            if (info != null)
            {
                foreach (var item in sources)
                {                    
                    sum += Convert.ToInt16(info.GetValue(item).ToString());
                    currentIndex++;
                    if (currentIndex % groupOfNum == 0 || currentIndex == sources.Count())
                    {
                        result.Add(sum);
                        sum = 0;
                    }
                }
            }
            return result;
        }
    }
}