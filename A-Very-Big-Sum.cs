using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class A_Very_Big_Sum
    {
        /*
         * Long tipinden sayıların olduğu bir liste var.
         * Bu listedeki sayıların toplamını döndürür.
         * Listenin eleman sayısı 0'dan büyük, 11'den küçük olacak.
         * Listenin elemanları 0 ve 10^10 kapsamında olacak.
         */
        public static long AVeryBigSum(List<long> ar)
        {
            long sum = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                sum += ar[i];
            }
            return sum;
        }
        
    }
}
