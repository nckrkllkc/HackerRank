using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class Simple_Array_Sum
    {
        // Tam sayılardan oluşan bir listenin içerisindeki elemanları tek tek toplayıp döndürür.
        // 0 < n,ar[i] <= 1000 => n - Listenin eleman sayısı, ar[i] - listenin içerisindeki her bir eleman
        public static int SimpleArraySum(List<int> ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                sum += ar[i];
            }
            return sum;
        }
    }
}
