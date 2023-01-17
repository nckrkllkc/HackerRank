using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class Compare_The_Triplets
    {
        /*
         * Alice ve Bob adında 2 kişi var. İsimlerinin baş harfinin temsil ettiği de 2 liste var.
         * Bu iki liste karşılaştırılıp hangi listedeki sayının büyük olduğunu tespit edeceksin.
         * Kimin sayısı büyükse onun hanesine 1 puan yazılıyor. Eğer sayılar eşitse herhangi bir puan kazanılmıyor.
         * En son Alice ve Bob'un puanlarını içeren yeni bir liste döndüreceksin.
         * İlk liste elemanı Alice'in puanı, ikinci liste elemanı Bob'un puanını temsil edecek.
         * Listedeki elemanlar 0'dan büyük, 101'den küçük olacak. (Kontrol ekleyince hata verdiği için bu kısım kodlanmayacak.)
         */

        public static List<int> CompareTheTriplets(List<int> a, List<int> b)
        {
            int alice = 0, bob = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    alice += 1;
                }
                else if (a[i] < b[i])
                {
                    bob += 1;
                }
            }
            return new List<int> { alice,bob };
        }
    }
}
