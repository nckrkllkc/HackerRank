using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class Solve_Me_First
    {
        // Kullanıcıdan alınan 2 adet tam sayının toplamını geri döndürür.
        // 1 <= a,b <= 1000
        public static int SolveMeFirst(int a, int b)
        {
            if (a >= 1 && a <= 1000 && b >= 1 && b <= 1000)
            {
                return a + b;
            }
            else
            {
                throw new Exception("Girilen değerler 0'dan büyük, 1001'den küçük olmalıdır!");
            }
            
        }
    }
}
