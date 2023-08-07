
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csarpalgorithmdesign3
{
    public class Sayi
    {
        /// <summary>
        ///  Parametre olarak aldigi sayinin tek mi cift mi oldunu kontrol eder
        /// </summary>
        /// <param name="n">Sayi</param>
        /// <returns>Tek ise true aksi durumda false donus yapar.</returns>
        public static bool TekMi(int n)
        {
            if (n % 2 == 1)
            {
                return true;

            }
            return false;
        }
        /// <summary>
        /// Parametre olarak aldığı sayinin cift olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="n">Girilen Sayi</param>
        /// <returns>n değeri çift ise  true aksi durumda false dönüs yapar.</returns>
        public static bool CiftMi(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Parametre olarak aldığı sayinin mutlak değeri döner
        /// </summary>
        /// <param name="n">Girilen sayiyi temsil eder</param>
        /// <returns>Girilen sayinin mutlak  değeri dönüş ifadesi olacak.</returns>
        public static int MutlakDeger(int n) // girilen n sayisinin mutlak değerini buşan program fonksiyonu 
        {
            if (n > 0)
                return n;
            else if (n < 0)
                return -1 * n;
            else
                return 0;
        }
        /// <summary>
        /// Girilen değerin asal sayı olup olmadığını kontrol eder
        /// </summary>
        /// <param name="n">Girilen sayiyi temsil eder </param>
        /// <returns>Girilen sayinin asal ifadesinin dönüşü olur</returns>
        public static bool AsalMi(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("En küçük asal sayi 2'dir.");
                return false;
            }
            bool kontrol = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) //  burada yani girilen n sayısının kendinden küçük bir sayıya bölündüğü için asal sayı değil ve kontrol durumunu false yapıyoruz
                {
                    kontrol = false;
                    break;
                }
            }

            return false;
        }
        /// <summary>
        ///  Parametre olarak aldığı sayinın rakamları toplamini doner 
        /// </summary>
        /// <param name="n">Girilen sayiyi temsil eder.</param>
        /// <returns>Rakamların toplamdir.</returns>
        public static int RakamlariToplami(int n)
        {
            int toplam = 0, rakam = 0;
            while (n > 0)
            {
                rakam = n % 10;
                toplam += rakam;
                n = n / 10;

            }
            return toplam;
        }
        /// <summary>
        /// i'nin değerini bir artırıp n'e kadar bir fazlasıyla toplayarak n'e kadar olan sayıların toplamını bulmak 
        /// </summary>
        /// <param name="n">Girilen sayiyi temsil eder</param>
        /// <returns>Girilen sayi n'e kadar olan sayiların toplamını döndürür</returns>
        public static int NeKadarOlanSayilarinToplami(int n)
        {
            /*
            int t = 0;
           
            for ( int İ =1; İ <=n; İ++)
            {
                t += İ; //standart kalıp i'nin değerini bir artırıp n'e kadar bir fazlasıyla toplayarak n'e kadar olan sayıların toplamını bulmak 
            }
            return t;
            */
            //formul ile birden n e kadar olan sayiların toplamnın bulmak 
            return n * (n + 1) / 2; //  görüldüğü gibi yukarıdaki yöntemle 8 satırda yaptıraln işlemi förmül ile tek küçük satırda aynı işlemi yaptırdım.
        }
        /// <summary>
        /// i'nin değerini bir arttıırıp i=1'den n'e kadar olan tek sayıların toplamını hesaplar
        /// </summary>
        /// <param name="n">Girilen n sayisini temsil eder</param>
        /// <returns>Girilen sayiyi n'e kadar olan tek sayiların toplamını döndürür</returns>
        public static int NeKadarOlanTekSayilarinToplami(int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    t += i;
                }
            }
            return t;
        }
        /// <summary>
        /// 1'den n'e kadar olan tek sayıların !den başlayarak 2 aratarak for döngüsünde tek sayıların toplamını hesaplar
        /// </summary>
        /// <param name="n">Girilen n sayiyi ifade eder</param>
        /// <returns>1'den n'e kadar olan tek sayıların !den başlayarak 2 aratarak for döngüsünde toplam t değerini döndürür </returns>
        public static int NeKadarOlanTekSayilarinToplamiAlternatifCozum(int n)// favori işlemim =) 
        {
            int t = 0;
            for (int i = 1; i <= n; i += 2)// Burada i=1 değerinden başladıktan sonra her bir döngüde i değerine 2 ekleyerek 1'den sonraki tek sayıları saydırmış olacağız (gerçekten çok zekice fsdfsd)
            {
                t += i; // burada da bizim toplamımızı ifade eden t değerine de döngüde birden iki arttırıp saydırdığımız her tek sayıyı da t değerinin üzerine " += " ekleyerek  i<=n 'e kadar olan tek sayilari topluyoruz.
            }
            return t;
        }
        /// <summary>
        /// 1'den n'e kadar olan tek sayiların förmüle ile hesaplanması 
        /// </summary>
        /// <param name="n">Girilen n sayisini ifade eder</param>
        /// <returns>!'den n'e kadar olan tek sayıların toplam değerini döndürür.</returns>
        public static int NeKadarOlanTekSayilarinFormulİleToplami(int n)// bu yöntem de favuri :)
        {
            n = n + 1; // n++; // alınan n değerini bir arttırdık 
            n = n / 2; // daha sonra bir arttırdığımız n değerini 2'ye böldük 
            return n * n; // ve iki böldükten sonraki n değerinin karesini aldık. 
            // böylelikle örnek n=5 için =5+1=6/2=3*3=9 yani 1+3+5= 9 'a karşılık gelmektedir.
        }
        /// <summary>
        /// 1'den n'e kadar olan çift sayıların 1'den 1'er artırarak if koşulu ile 2'ye kalansız bölünen n 'e kadar olan sayilar, toplar
        /// </summary>
        /// <param name="n">Girilen n saiysini temsil eder</param>
        /// <returns>1'den başlayarak n'e kadar olan sayıları birer artırarak if dönğüsüyle 2'ye kalansız bölündüğünü kontrol eder ve sağlayanların toplam değerini döndürür.</returns>
        public static int NeKadarOlanCiftSayilarinToplami(int n)
        {
            int t = 0;
            for (int i = 2; i <= n; i++) // İ=2'den başlayarak n'e kadar birer artırarak döngüyü kurar
            {
                if (i % 2 == 0) // i değerinin 2 'den kalanının 0 koşulunu konrol eder 
                {
                    t += i;   // eğer if konuşu sağlanır ve birer artarak devam eden döngü içinde 2'ye kalansız bölünen i değeri olursa toplam ifademiz olan t değerinin üzerine i değerini ekleyerek güncel t değerini elde ederiz.

                }
            }

            return t;
        }
        /// <summary>
        /// 1 den n'kadar olan çift sayıların toplamını alternatif yöntemle bulunması
        /// </summary>
        /// <param name="n">Girilen n sayisini ifade eder.</param>
        /// <returns>1'deb başlayarak n'e kadar olan çift sayıları 2 şer şekilde  for döngüsünde saydırarak toplam t değeri döndürür.</returns>
        public static int NeKadarOlanCiftSayilarinToplamiAlternatifCozum(int n)
        {
            int t = 0;
            for( int i=2;i<=n; i +=2)
            {
                t += i;
            }
            return t;
        }
        /// <summary>
        /// 1'den n'e kaddar olan çift sayıları 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int NeKadarOlanCiftSayilarinFormulleToplami(int n)
        {
            n = n / 2; // klavyeden aldığımız sayıyı ikiye böldük
            return n * (n + 1); // daha sonra  ikiye bölünen n değerini n*(n+1) förmülü ile n'e kadar olan çift sayıların toplamını bulduk
        }

        public static double pi = Math.PI; // matematik kütüphanesiden pi 'nin değerini çekiyoruz

        public static double Cevresi(double r) // Burada consoleread ile aldığımız r değerini çekip döndürdüğümüz değeri Cevresi()  cevresi değişkenine veriyoruz 
        {
            return 2 * pi * r;  // işlemi yaparak sonucunu döndürüyoruz 
        }
    }
}





/*
using System.Text;
using System.Threading.Tasks;

namespace csarpalgorithmdesign3
{
    public class Sayi
    {
        /// <summary>
        ///  Parametre olarak aldigi sayinin tek mi cift mi oldunu kontrol eder
        /// </summary>
        /// <param name="n">Sayi</param>
        /// <returns>Tek ise true aksi durumda false donus yapar.</returns>
        public static bool TekMi(int n)
        {
            if (n % 2 == 1)
            {
                return true;
            }

            return false;
        }
    }
}
*/