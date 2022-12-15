using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    static class Staircase
    {
        // Enumerable.Repeat => Belirtilen string'i istenilen kadar tekrar ederek IEnumerable<string> tipinde bir yapı
        // döndürüyor.
        // String.Concat => String birleştirmek için kullanılır. Overload metotlarından birisi de IEnumerable<string> tipindeki
        // yapının içerisinde bulunan stringleri birleştiriyor.
        
        public static void staircase(int n)
        {
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(String.Concat(Enumerable.Repeat(" ", (n - i))) + String.Concat(Enumerable.Repeat("#", i)));
            }
        }
    }
}
