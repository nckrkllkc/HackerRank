using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    static class Diagonal_Difference
    {
        /*
         * Satır ve sütunları eşit miktarda olan liste tutan bir liste var.(Matrix :) )
         * Soldan sağa çapraz ([1.listenin][1.elemanı],[2.listenin][2.elemanı],[3.listenin][3.elemanı] gibi), 
         * sağdan sola çapraz ([1][3],[2][2],[3][1]) (X gibi düşün) şekilde sayıları listelerden çekerek alacaksın.
         * Bunlar aralarında toplanacak ve her iki yönün sonuçları birbirlerinden çıkartılacaklar. Sonuç mutlak değer olarak döndürülecek.
         * 1 2 3
         * 4 5 6
         * 7 8 9
         * |(1+5+9) - (3+5+7)| => |15 - 15| = 0 gibi.
         * Listelerdeki sayılar -101'den büyük, 100'den küçük olacak.
         */
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int leftToRight = 0, rightToLeft = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                leftToRight += arr[i][i];
                rightToLeft += arr[i][arr.Count - (1 + i)];
            }
            return Math.Abs(leftToRight - rightToLeft);
        }

    }
}
