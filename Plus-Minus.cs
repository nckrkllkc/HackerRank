using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    static class Plus_Minus
    {
        public static void PlusMinus(List<int> arr)
        {
            /*
             * Tam sayılardan oluşan bir liste var. İçerisindeki kaç tane sıfırdan büyük, sıfıra eşit ve sıfırdan küçük eleman varsa
             * bu elemanların adetini listenin eleman sayısına bölüyoruz. İstenen çıktı aşağıdaki gibidir.
             * Liste 0'dan büyük 101'den küçük olacak şekilde eleman sayısına sahip olabilir.
             * İçerisindeki elemanların alacağı değer -101'den büyük, 101'den küçük olabilir.
             */

            /*
             * Format içerisinde kullanılan ilk 0 virgülden sonraki ilk değeri temsil ediyor.
             * : işaret formatlamanın nasıl yapılacağını tanımlamak için kullanılır.
             * String.Format("{0:0.000000}", arr.Where(n => n > 0).ToList().Count / arrCount)
             */

            /*
             * Tamsayının ondalıklı bir sayıya bölümü yine ondalıklı olarak çıktı verir.
             * Bellek boyutu en düşük olan float (Single) tercih edilmiştir.
             * Değişken tanımlamadan yapmak isterseniz lambda expression tanımını aşağıdaki gibi de yapabilirsiniz.
             * arr.Where(n => n > 0).ToList().Count / Convert.ToSingle(arr.Count)
            */
            float arrCount = Convert.ToSingle(arr.Count); // Optional
            Console.WriteLine(String.Format("{0:0.000000}", arr.Where(n => n > 0).ToList().Count / arrCount));
            Console.WriteLine(String.Format("{0:0.000000}", arr.Where(n => n < 0).ToList().Count / arrCount));
            Console.WriteLine(String.Format("{0:0.000000}", arr.Where(n => n == 0).ToList().Count / arrCount));

        }
    }
}
