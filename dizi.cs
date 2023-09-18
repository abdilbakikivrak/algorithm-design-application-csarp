using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace algorithmdesign3ortaa.cs
{
    internal class dizi
    {

        /// <summary>
        /// her yerden çağırılabilen public bir olustur dizisi 
        /// </summary>
        /// <param name="limit">dizi</param>
        /// <returns></returns>
        public int[] olustur(int limit)
        {
            int[] sayilar = new int[limit]; // limit değerine tanımlı sayilar  adında yeni  bir dizi oluşturuyoruz, bu dizi dışarıdan bir parametre alacak ve bu parametreye bağlı olarak bir dizi oluşturacak

            Console.WriteLine(""); //** 
            for (int i =0; i <limit;i++) // limit değeri kadar döngü saydırıyoruz
            {
                sayilar[i] = new Random().Next(1, 100);  // limit kadar dönerken her seferinde 1 ile 100 arasında randım bir sayı üretiyor
                Console.WriteLine(" {0,3} ", sayilar[i]); // oluşturulan değerleri sırayla yazdırır 
            }
            Console.WriteLine("");//**
            return sayilar;
            
        }

        /// <summary>
        /// yeni üretilen sayilar dizisi içindeki en büyük sayıyı bulan public bir fonksiyon
        /// </summary>
        /// <param name="dizi">dizi</param>
        /// <returns></returns>
        public static int EnBuyuk(int[] dizi)  
        {
            int eb = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > eb)
                {
                    eb = dizi[i];
                }

            }
            return eb;
        }

        /// <summary>
        ///  yeni üretilen sayilar dizisi içindeki en küçük sayıyı bulan bir fonsiyon
        /// </summary>
        /// <param name="dizi">dizi</param>
        /// <returns></returns>
        public static int EnKucuk(int[] dizi) 
        {
            int ek = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] < ek)
                {
                    ek = dizi[i];
                }

            }
            return ek;
        }

        /// <summary>
        /// Random üretilen dizinin içindeki değerlerin aritmetik ortalamsını bulan 
        /// </summary>
        /// <param name="X"></param>
        /// <returns></returns>
        public static double AritmetikOrtalama(int[] X)
        {
            double toplam = 0;
            for  (int i=0; i<X.Length; i++ ) // 0'dan birer artarak x length boyunca döngüye devam eder
            {
                toplam += X[i]; // dizideki her bir elemanı döngüde sayacak ve değerlerini toplam değerine atacak 
            }
            return (toplam / X.Length) ; // burada ise X.length adedi boyunca tüm olan değerlerin toplamına bölerek aritmetik ortalamasını bulur
        }

        /// <summary>
        /// Bir dizinin standart sapmasını hesaplayan program 
        /// </summary>
        /// <param name="X">dizi</param>
        /// <returns></returns>
        public static double StandarSapma(int[] X)
        {
            double aritmetikortalama = AritmetikOrtalama(X);
            
            double t = 0, f = 0, std=0 ; //stansart sapma ve aritmetik ortalamanın farkını ve  karesi ve std değeri 
            for (int i = 0; i < X.Length; i++) // dizinin içinde X değeri kadar dolaşacağım için for döngüsü açtım

            {
                f = X[i] - aritmetikortalama;
                t += Math.Pow(f,2); // kümülatif toplama ile üst satırda hesaplanan f değerinin math.pow ile karesini alıp t değişkenine ekliyoruz
                 
                
            }

            std = t / (X.Length - 1);
            std = Math.Sqrt(std);
            return std;
            // return Math.Sqrt( t/(X.Length -1)); // kısa çözüm olarak 
        }

        /// <summary>
        /// Klavyeden index değeri girilen random oluiturulan dizinin içerisindeki tek sayilari sayan program
        /// </summary>
        /// <param name="X">dizi ->X </param>
        /// <returns></returns>
        public int TekSayilarinSayisi(int[]X)
        {
            int teksayilarinsayisi = 0;

            for(int i=0; i<X.Length; i++)
            {
                if (X[i] %2==1)
                {
                    teksayilarinsayisi++;// if koşulu ile dizinin içindeki dönen değerlerden 2'ye kalanlı bölünüyorsa teksayilarin sayisini bir artırıyoruz 
                }

            }
            return teksayilarinsayisi;
        }

        /// <summary>
        /// Klavyeden index değeri girilen random oluiturulan dizinin içerisindeki çift sayilari sayan program
        /// </summary>
        /// <param name="X">dizi ->X </param>
        /// <returns></returns>
        public int CiftSayilarinSayisi(int[] X)
        {
            int ciftsayilarinsayisi = 0;

            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0) //X[i] dizisindeki 2'ye kalansız bölünen çift sayıları if koşulu olarak  saydırır 
                {
                    ciftsayilarinsayisi++;// if koşulu ile dizinin içindeki dönen değerlerden 2'ye kalanlı bölünüyorsa teksayilarin sayisini bir artırıyoruz 
                }

            }
            return ciftsayilarinsayisi;
        }

        /// <summary>
        /// Ratgele oluşturulan randım dizideki tek sayilari bulup, tek sayilardan yeni dizi çıkaran fonksiyon 
        /// </summary>
        /// <param name="X">dizi X</param>
        /// <returns></returns>
        public int[] TekliDiziOlustur(int[] X)
        {
           // int teksayilarinsayisi = TekSayilarinSayisi(X);
            int[] tekdizi = new int[TekSayilarinSayisi(X)];
            int y = 0;
            for ( int i=0; i< X.Length; i++)
            {
                if (X[i]%2==1)
                {
                    tekdizi[y] = X[i];
                    y++;
                }
               
            }
            return tekdizi;
        }

        /// <summary>
        /// Rastgele oluşturulan random dizideki çift sayilari bulup, çift sayilardan yeni dizi çıkaran fonksiyon 
        /// </summary>
        /// <param name="X">dizi X</param>
        /// <returns></returns>
        public int[] CiftliDiziOlustur(int[] X)
        {
            // int ciftsayilarinsayisi = CiftSayilarinSayisi(X);
            int[] ciftdizi = new int[CiftSayilarinSayisi(X)];
            int y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                {
                    ciftdizi[y] = X[i];
                    y++;
                }

            }
            return ciftdizi;
        }

        /// <summary>
        /// Parametre olarak aldığı diziyi ekrana yazdırır. 
        /// </summary>
        /// <param name="X">dizi</param>
        public static void Yazdir(int[] X)
        {
            Console.WriteLine("");
            for(int i=0; i<X.Length; i++) // X.length yani x diziainin uzunluğu kadar dönelim
            {
                Console.Write("{0,3}", X[i]);

            }
            Console.WriteLine("");

        }
    }
}
