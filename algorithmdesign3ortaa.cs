
/*
// iç içe for ve for döngüleri ile sayılarla işlemler 1000'den beş beş 0' kadar  // 1'den 100 'e çift sayılar vs 
 using System;

namespace ABK
{
    class Program
    {
        static void Main(string[] args)
        {
            int teksayitoplam = 0, ciftsayitoplam =0;
            Console.WriteLine("Limit değerini giriniz : ");
             int limit = Convert.ToInt32(Console.ReadLine());// Convert metodu ile klavyeden girilen string türündeki ifadeyi int türüne çevirdim
            int t;
            int n = 100;
            int d = 0;

            for (int i=1;i<=limit; i++)
            {
                // t = i * i;  // birden 100'e kadar olan sayıların birer artırarak karelerini yazar
                if (i % 2 == 0) // 100'e kadar olan çift sayıları döndürür ve koşulu sağlanı ekrana yazar
                {
                    ciftsayitoplam += i; // sayılan çift sayiları çifttoplam ifadesinde toplar 
                    Console.WriteLine("çift:{0}", i);
                }

                if (i % 2 == 1) // 100 e kadar olan tek sayiları if koşulu ile sayar 
                {
                    teksayitoplam += i; // if koşuşulu ile sayilan tek sayilari teksayi toplam ifadesinde toplar
                    Console.WriteLine("tek:{0}", i);// {0,5} demek 5 karakter boluk bırakarak 0 tanımını  yaz demek
                }

            }
            for ( int i=1000; i>0; i-=5)// 1000'den 0'a kadar 5'er 5'er azalarak sayan döngü
            {
                Console.WriteLine(i);
                d++;// her beşer beşer azaldığı döngü yaparken d değişkeninde attığı döngü sayısını d++ ile değerini her seferinde bir arttırarak sayar (bir tür adım sayacı olur)
            }
            Console.WriteLine(" \n\n Kaç adet 1000'den 5'e kadar sayi var :{0}",d);
            Console.WriteLine("Tek sayilar Toplam: {0}  Çift Sayilar Toplam: {1}", teksayitoplam, ciftsayitoplam); // ayrı ayrı toplamları ekrana bastım



            Console.WriteLine("## Çarpım tablosu uygulaması.. "); // iç içe for döngüsü kullanarak çarpım tablosu 
            for (int i=1; i<=10; i++) // çarpım tablosu için i deperini 1'den 10'a kadar birer artırarak sayar
            {
                for (int j =1; j<=10;j++) // ilk for döngüsünün her döngüyü saydığında buradaki for döngüsü de kendi içinde bir j değerini birer artırarak j değeri 10 değerini sayıncaya kadar  döndürür ve sonraki adımda  iç döngü tamamlanır ve il döngü i=2 ifadesinden devam eder
                {
                    Console.WriteLine("{0,5} \tx {1,5}={2,5}", i, j, i * j); //her adımdada içiçe döngüyle gelen i ve j degerini çarpar ve akrana yazar
                }

                Console.WriteLine("#################...............");
            }
        }
    }
}
 */


// DİZİLER
// rastgele oluştrulan tek dizide en büyük ve en küçük elemanları bulan  program

using algorithmdesign3ortaa.cs;
using System;
using System.Collections.Generic;

namespace baki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n değerini giriniz.");
            //int limit = Convert.ToInt32(Console.ReadLine()); // konsol ifadesinden girilen sayiyi Convert ile integara ataıyoruz 

            /*
            int[] sayilar = new int[limit]; //oluşturduğumuz sayilar dizisi için dizinin index'ini kullanıcıdan aldığımız kullanıcıdan alınan limit değeri  için int dizi index değerini limit değişkenine atıyoruz
            
            for (int i=0; i<limit;i++ )   // dizilerde index 0'dan başladığı için for döngüsü ile limit değerine kadar birer artırarak saydırırız
            {
                sayilar[i] = new Random().Next(45, 100);   // limit değeri adedinde döngünün saydığı sayılardan random olarak 45 ile 100 değerleri arasındaki sayılardan 
                Console.WriteLine("{0,5}", sayilar[i] );   // {0,5} tipinde üretilen yeni sayilar[i] dizisini ekrana yazdırır
            }
            */
           // int[] sayilar = new dizi().olustur(limit);  // oluşturduğumuz dizi class'ı ile klavyeden aldığımız değerin dizi oluşturma işlemini dizi class'ı ile sağlayacak

            // Console.WriteLine("\n Dizinin en büyük elemanı:{0} ", dizi.EnBuyuk(sayilar)); // en büyük ve en küçük elemanları bulan foksiyon kodlarını dizi.cs class'ı içerisine aldığımdan dolayı dizi.EnBuyuk() olarak fonksiyonu dizi classından çağırdım 
            // Console.WriteLine("\n Dizinin en küçük elemanı:{0} ", dizi.EnKucuk(sayilar));



            // dizi elemanlarının aritmetik ortalamalarını bulma 

            int n = Convert.ToInt32(Console.ReadLine());
            int[] X = new dizi().olustur(n);
            /*
            Console.WriteLine("Dizinin aritmetik ortalaması :{0:F2}", dizi.AritmetikOrtalama(X));// dizi class'ında yazdığım artimetik ort hesabı fonksiyonunu çağırıp X' parametresine bağlı işlemin sonucunu yazdı
            Console.WriteLine("Dizinin standart sapması :{0:F2}", dizi.StandarSapma(X));
            */

            // Dizi dizi = new Dizi();
            dizi dizi2 = new dizi();// burada dizi.cs class'ına bağlı dizi1 adında yeni bir nesne tanımlıyoruz böylelikle dizi.cs içerisinde static olarak tanımlanmamış fonksiyonlara yeni tanımladığımız dizi1.*** diyerek erişebiliyoruz 
            int[] tekSayilarDizisi = dizi2.TekliDiziOlustur(X);
            dizi.Yazdir(tekSayilarDizisi); // buradaki yazdir fonksiyonu dizi.cs içerisinde static olarak tanımlı olduğundan direkt çağırabiliyoruz

            Console.WriteLine("Tek Sayilarin Sayisi:{0,5}", tekSayilarDizisi.Length); // tek sayilar dizisindeki değerler bıyunca yazdırır
                                                                                      //dizi2.TekSayilarinSayisi(X); tanımladığımız nesneden de çözdürebiliriz

            int[] ciftSayilarDizisi = dizi2.CiftliDiziOlustur(X);
            dizi.Yazdir(ciftSayilarDizisi);

            Console.WriteLine("Çift Saiylarin Sayisi: {0,5}", ciftSayilarDizisi.Length);
        }
        /*
        public static int EnBuyuk(int[] dizi)  // yeni üretilen sayilar dizisi içindeki en büyük sayıyı bulan public bir fonksiyon 
        {
            int eb = dizi[0]; 
            for (int i=1; i<dizi.Length; i++ )
            {
                if (dizi[i] > eb)
                {
                    eb = dizi[i];
                }

            }
            return eb;
        }
        public static int EnKucuk(int[] dizi ) // yeni üretilen sayilar dizisi içindeki en küçük sayıyı bulan bir fonsiyon 
        {
            int ek = dizi[0];
            for(int i=1; i<dizi.Length; i++)
            {
                if (dizi[i]<ek)
                {
                    ek = dizi[i];
                }
                
            }
            return ek;
        }
        */
    }
}

/*
using System;

namespace ABK
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
*/