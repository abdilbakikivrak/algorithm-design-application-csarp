/*
using System;

namespace abdil // Note:gerçek ad alanı prıje alanına bağlıdır.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i=65; i<= 90; i++)
            {
                Console.Write(" {0}", (char)i); // (char)i şeklinde yazdığımız zaman program 65'den 90'a kadar olan rakamların ascii karşılıklarını yazdırır 

                if (i%5==0) // burada ise çıktılar 5'er 5'er ayrılarak bir alt satırdan devam etmesi için if koşulu ile ayırırız 
                {
                    Console.WriteLine("");// 
                }
            }
           
        }
    }
}
*/


using algorithmdesign4orta; 
using algorithmdesign3ortaa.cs; // burada using .. diyerek diziler class'ını sonradan bu projeye dahil edip kullanıyorum ya da dizi.cs içerisine gidiğ en baştaki namespace tanımını program tanımıyla aynı yaparak sağlayabiliriz 
using System;

namespace abdil // Note:gerçek ad alanı prıje alanına bağlıdır.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string1.Desen1('*', 5);// burada string1 class'ı içinde tanımladığımız Desen1 fonksiyonu ile char türünde girdiğimiz deseni tanımladığımız adette fonksiyonda tanımlı olduğ şekil  deseni çıkarıyor 
            string1.Desen1(); // normalde hiç parametre almayan bir methot yok ancak burada hiç parametre olmamasına rağmen çalışacak çünkü tanımladığım string1 class'ında default olarak çalıştırabileceği char c ve  int n değerleri tanımlı  
            string1.Desen1('!');// buradaki methot ise char  karakteri  olarak verilen yeni parametreyi ! baz alır , n değerini (basamak değeri) default tanımdan devam eder 
            string1.Desen1('?', 10);// burada ise hem char türü hem de int n değerlerinin parametrelerini yeni girilene desen1 fonsksiyonunu çalıştırır göre çalıştırır 

            string1.Desen2();
            string1.KarakterSeti();
            string1.KarakterSeti(128,255);
            string1.KarakterSeti(128,255,10);

            

            // String Fonksiyonları

            string ifade = " baki ";
            Console.WriteLine(ifade);
            Console.WriteLine(ifade.Length);
            Console.WriteLine(ifade.Trim());
            Console.WriteLine(ifade.Trim().Length);
            Console.WriteLine(ifade.TrimStart());
            Console.WriteLine(ifade.TrimEnd());
            Console.WriteLine(ifade.ToLower());
            Console.WriteLine(ifade.ToUpper());
            Console.WriteLine(ifade.Replace('b','a')); // b rakamını a rakamı ile değiştir









        }
    }
}


/*
using System;

namespace MyApp // Note:gerçek ad alanı prıje alanına bağlıdır.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
*/