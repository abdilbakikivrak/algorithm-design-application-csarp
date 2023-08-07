/*

// Klavyeden girilen sayinin tek mi cift mi olduğunu public class fonsiyonu çağırılarak işleme alınması 
using csarpalgorithmdesign3;
using System;

namespace ABK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi girin:");
           int n= Convert.ToInt32( Console.ReadLine());
            int m = 4;
            if (Sayi.TekMi(n)) //  oluşturduğumuz sayi.cs sınıfında bu işlemi yapan TekMi() foksiyonunu buraya çağırıp kullanıyoruz 
            {
                Console.WriteLine("Grilen sayi= {0} tektir.", n);


            }
            if (Sayi.CiftMi(n)) // bu çalışmanın  oluşturduğumuz  sayi.cs sınıfında bu işlemi yapan CiftMi() foksiyonunu buraya çağırıp kullanıyoruz 
            {
                Console.WriteLine("Girilen sayi = {0} çifttir.", n,m);  
            }
        }
    }
}
*/
/*
// Class fonk kullanılarak girilen sayinin mutlak değerini buluyoruz

using csarpalgorithmdesign3;
using System;

namespace ABK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mutlak Deger İçin sayi giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("|{0}|={1}",n, Sayi.MutlakDeger(n));
            
        }
    }
}
*/
/*
//Asal sayi olup olmadığını sınıf  fonsiyonu ile bulan program
using csarpalgorithmdesign3;
using System;

namespace ABK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Asal Sayi kontrolü İçin sayi giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", Sayi.AsalMi(n) ? "Asal Sayidir." : "Asal Sayi değildir.!");// AsalMi(n) sınıf fonksiyonundaki asal sayi kontrol fonksiyonuna girilen n değerini kontrol ettirip ekrana yazırıyoruz.
                                                // n, Sayi.AsalMi(n)? "Asal Sayidir.": "Asal Sayi değildir.") bu ifade de ?'den hemen sonraki durumu true sonraki ikinci durumu false olarak değerlendirip ekrana yazacaktır.
        }                                       // soru işaretinden önceki ifade true ise soru işaretinden sonraki ifade true olur yazılır , false ise soru işaretinden iki soneaki ifade false olarak yazılır
    }
}
*/
/*
//Girilen Sayinin rakamları toplamını class fonsiyonu ile bulan program
using csarpalgorithmdesign3;
using System;

namespace ABK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rakamları Toplami icin sayi giriniz.");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} Sayisinin Rakamları Toplamı = {1}",n,Sayi.RakamlariToplami(n));// burada ilk kısımda n ile {0} atadığımız yere girilen sayıyı yazıp daha sonra {1} ile yazdığımız class fonksiyonu ile n değerinin rakamlarının toplamını yazıyor.


        }
    }
}
*/

/*
// Birden n'e kadar olan sayıların toplamı class fonksiyonu ile hesaplayan işlmeme alan program ###(standar artan toplama yöntemi ve förmül ile hesaplama )

using csarpalgorithmdesign3;
using System;

namespace ABK
{//peachypam
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İşlemi Hesaplanacak Sayiyi giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birden {0}'e kadar olan sayiların       Toplamı ={1,5}", n, Sayi.NeKadarOlanSayilarinToplami(n));
            Console.WriteLine("Birden {0}'e kadar olan  tek sayiların  Toplamı ={1,5}", n, Sayi.NeKadarOlanTekSayilarinToplami(n));
            Console.WriteLine("Birden {0}'e kadar olan  tek sayiların  Toplamı Alternatif Çözm ={1,5}", n, Sayi.NeKadarOlanTekSayilarinToplamiAlternatifCozum(n));
            Console.WriteLine("Birden {0}'e kadar olan  tek sayiların Förmülle Toplamı ={1,5}", n, Sayi.NeKadarOlanTekSayilarinFormulİleToplami(n));
            Console.WriteLine("Birden {0}'e kadar olan Çift Sayıların   işlemi :{1}-{2}={3}",n, Sayi.NeKadarOlanSayilarinToplami(n), Sayi.NeKadarOlanTekSayilarinToplami(n), Sayi.NeKadarOlanCiftSayilarinToplami(n));
            Console.WriteLine("Birden {0}'e kadar olan Çift  sayiların Toplamı ={1,5}", n, Sayi.NeKadarOlanCiftSayilarinToplami(n));
            Console.WriteLine("Birden {0}'e kadar olan Çift  sayiların Toplamı Alternatif Çözum ={1,5}", n, Sayi.NeKadarOlanCiftSayilarinToplamiAlternatifCozum(n));
            Console.WriteLine("Birden {0}'e kadar olan Çift sayiların Förmülle Toplamı ={1,5}", n, Sayi.NeKadarOlanCiftSayilarinFormulleToplami(n));


            // 50'den 80 kadar olan çift sayiların toplamını bulan program ####################################
            /*
            int n = 80;
            int m = 50; // bu şekilde de ayrı tanımlayabilirdim ama değişkene gerek yok fonksiyon parantezinin içerisine yazmak daha kolay.
            "///

            int t1 = Sayi.NeKadarOlanCiftSayilarinFormulleToplami(80);
            int t2 = Sayi.NeKadarOlanCiftSayilarinFormulleToplami(50);

            Console.WriteLine("{0,5}-{1,5}={2,5}", t1, t2, t1 - t2); // yukarıda 106. satırda ekrana gösterilen işlemi bu defa gerçek olarak işleme alındı tanımlanan değerleri çıkarakar istenen aralıktaki sayıların toplamını elde edebildik 
        }
    }
}
*/

/*

// bir çemberin çevresini ve alanını hesaplayan program
using System;

namespace ABK
{
    class Program
    {
        static void Main(string[] args)
        {

            const double pi = Math.PI;
            Console.WriteLine("Çemberin Yarıçapı r değerini giriniz:");
            double r =Convert.ToInt32( Console.ReadLine()); // Burada konsoldan alınan string türündeki değeri convert.toint32 deyimi ile double türüne değiştirilebilir yaptım
            Console.WriteLine("Cevresi:2*{0:F2}*{1:F2}={2:F2}", pi  ,r,2*pi*r);// işlem çıktıısnı ekrana yazdırıyoruz  {0:F2} ifadesi referans alınan {0} değerinin virgülden sonra sadece iki basamağını yazdırır
            Console.WriteLine("Alanı:{0:F3}*{1:F3}*{1:F3}={2:F2}", pi, r, pi * r*r);
        }

    }
}
*/

// Yarı çapı ve açısı girilen çember diliminin alanını hesaplayan denklem ve program
using System;

namespace ABK
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = Math.PI; // pi değerini atadık 
            Console.WriteLine("Çemberin Yarıçapı 'r'  değerini  giriniz:");
            double r = Convert.ToInt32(Console.ReadLine()); // yarı çap değerini aldık ve string türünden doulble türüne değiştirmesi için de convertToint32 düğümü kullandık
            Console.WriteLine("Çemberin yaptığı açı 'aci'  değerini  giriniz:");
            double aci = Convert.ToInt32(Console.ReadLine()); // Çember diliminin yaptığı açı  değerini aldık ve string türünden doulble türüne değiştirmesi için de convertToint32 düğümü kullandık
            Console.WriteLine("Alanı:{0:F4}*{1}*{1}*{2}/360={3:F5}", pi, r,aci,  pi * r*r*aci/360); // burada çebner diliminin alanını hesaplayan denklemi yazdık A=pi*r*r*aci/360
            //Console.WriteLine(pi);
        }
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