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
            // : işaret formatlamanın nasıl yapılacağını tanımlamak için kullanılır.
            // Devamındaki tanım zaten format tanımı :)

            // Değişken tanımlayarak da çözebilirsiniz. Ben gereksiz yere bellek israfı olmaması için bu şekilde yaptım.
            // Otorite değilim. Doğrusu budur demiyorum. Daha sonra kullanma ihtiyacım yoksa değişken tanımlayıp, bellek
            // israfına girmemenin doğru yöntem olduğunu öğrendim. O yüzden bu şekilde yazdım :)

            Console.WriteLine(String.Format("{0:0.000000}", Convert.ToDecimal(arr.Where(n => n > 0).ToList().Count) / Convert.ToDecimal(arr.Count)));
            Console.WriteLine(String.Format("{0:0.000000}", Convert.ToDecimal(arr.Where(n => n < 0).ToList().Count) / Convert.ToDecimal(arr.Count)));
            Console.WriteLine(String.Format("{0:0.000000}", Convert.ToDecimal(arr.Where(n => n == 0).ToList().Count) / Convert.ToDecimal(arr.Count)));
        }
    }
}
