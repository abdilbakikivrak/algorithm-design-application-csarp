using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithmdesign4orta
{
    internal class @string1
    {

        /// <summary>
        /// Ters üçgen desen oluşturucu blok 
        /// </summary>
        /// <param name="c">Karakter tanımı</param>
        /// <param name="n">Tekrar Sayısı </param>
        public static void Desen1(char c='*', int n=5 )
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("{0,10}", new string(c, i)); // "{0,10}" 0-> il tanımı temsil ediyor / 10 ise satırda 10 karakter boşluk ayrıldığını ve bu 10 karakter alanın sağ tarafından itibaren doldurarak $ yazar 

            }
        }

        /// <summary>
        ///  Desen oluiturucu 2
        /// </summary>
        /// <param name="c">Karakter</param>
        /// <param name="n">Döngü Sayısını</param>
        public static void Desen2(char c='?', int n =8)
        {
            for (int x=n; x>= 0; x--)
            {
                Console.WriteLine("{0,10}", new string(c, x));
            }
        }

        /// <summary>
        /// Karakter Seti belirleme 
        /// </summary>
        /// <param name="baslangincindisi"></param>
        /// <param name="bitisindisi"></param>
        public static void KarakterSeti(int baslangincindisi=65 , int bitisindisi=90 , int satirkaraktersayisi=5)
        {
            for (int i = baslangincindisi; i <= bitisindisi; i++)
            {
                Console.Write(" {0}", (char)i); // (char)i şeklinde yazdığımız zaman program 65'den 90'a kadar olan rakamların ascii karşılıklarını yazdırır 

                if (i % satirkaraktersayisi == 0) // burada ise çıktılar 5'er 5'er ayrılarak bir alt satırdan devam etmesi için if koşulu ile ayırırız 
                {
                    Console.WriteLine("");// 
                }
            }
        }
    }
}
