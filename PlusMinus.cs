using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    static class PlusMinus
    {
        public static void plusMinus(List<int> arr)
        {
            // Format içerisinde kullanılan ilk 0 virgülden sonraki ilk değeri temsil ediyor.
            // : işaret formatlamanın nasıl yapılacağını tanımlamak için kullanılır. Son hane yuvarlanır.
            // Devamındaki tanım zaten format tanımı :)

            // arr.Where(n => n > 0).ToList().Count / Convert.ToDecimal(arr.Count)
            // veya
            // arr.Where(n => n > 0).ToList().Count / arrCount

            // Değişken tanımlayarak da çözebilirsiniz. Daha sonra kullanma ihtiyacım yoksa değişken tanımlayıp, bellek
            // israfına girmemenin doğru yöntem olduğunu okumuştum bir yerde. Değişken tanımlamadan kullanılan yöntemde convert
            // etme ve listenin eleman sayısını alma işlemini 3 defa yapmış olduk. Hangisinden feragat etmek istersin
            // deseler bellek derim. Ram candır ama işlemci de öyle. O yüzden değişken tanımlamasıyla fazla işlemden kaçınmış
            // olduk :)

            decimal arrCount = Convert.ToDecimal(arr.Count);
            Console.WriteLine(String.Format("{0:0.000000}", arr.Where(n => n > 0).ToList().Count / arrCount));
            Console.WriteLine(String.Format("{0:0.000000}", arr.Where(n => n < 0).ToList().Count / arrCount));
            Console.WriteLine(String.Format("{0:0.000000}", arr.Where(n => n == 0).ToList().Count / arrCount));

        }
    }
}
