using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    static class Mini_MaxSum
    {
        public static void miniMaxSum(List<int> arr)
        {
            /*
             * Tam sayılardan oluşan bir listemiz var. En büyük sayı ve en küçük sayı gözardı edilerek 2 sefer (büyük ve küçük için ayrı ayrı)
             * listenin elemanları toplanacak.
             * Ekrana "enKücükHaricToplam enBüyükHariçToplam" şeklinde yazdırılacak.
             * Listenin elemanları 0'dan büyük, 10^9 dan küçük veya eşit olacak.
             */

            // Birinci elemandan 1 tane bile farklı sayı bulursa liste farklı sayılardan oluşuyor demektir.
            if (arr.Any(n => n != arr[0]))
            {
                int min = arr.Min();
                int max = arr.Max();
                long tempSumMax = default;
                long tempSumMin = default;

                List<int> tempList = new List<int>();
                foreach (int n in arr)
                {
                    if (n != max)
                    {
                        tempSumMax += n;
                    }
                    if (n != min)
                    {
                        tempSumMin += n;
                    }
                }
                

                Console.Write(tempSumMax + " " + tempSumMin);
            }
            else
            {
                // Liste tamamen aynı sayılardan oluşuyorsa listenin eleman uzunluğunun 1 eksiğiyle ilk elemanın çarpımı
                // istediğimiz sonucu verir.
                long tempSum = (arr.Count - 1) * arr[0];
                Console.Write(tempSum + " " + tempSum);
            }

        }
    }
}
