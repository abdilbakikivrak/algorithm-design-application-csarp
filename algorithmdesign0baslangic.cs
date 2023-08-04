
using System;

namespace MyApp //
{
    internal class Program
    {
        public static class MyApp02
        {
            static void Main(string[] args)  //burada olturduğumuz fonksiyon ile yazdığımız kodu fonsiyon tipinde  çalıştırabiliyoruz
            {
            int sayi1 = 23, sayi2;
            int maks, mins, maks32, mins32;
            byte minByte = System.Byte.MinValue; // sistem sınıfından min değerinde byte tipinde min değerini ister
            byte maxByte = System.Byte.MaxValue;
            maks = System.Int16.MaxValue;
            mins = System.Int16.MinValue;

            maks32 = System.Int32.MaxValue;
            mins32 = System.Int32.MinValue;

            sayi2 = (sayi1* 8) + 1;
            Console.WriteLine("sonuc:{0} \t\t\t sayi2:{1} ", sayi2*3 , sayi2 );// burada {0} olarak sonuç değeri yani ilk sıradan tanımladığımız ekrana yazdırılacak değişkeni ve devamondaki ekrana yazılan sayi2 değerini ekrana yazdırır
            Console.WriteLine("int16-> Min: {0} \t\t Mak:{1}", mins, maks);
            Console.WriteLine("int32-> Min: {0} \t Mak:{1}", mins32, maks32);
            Console.WriteLine("Byte-> Min: {0} \t\t\t Mak:{1}", minByte, maxByte);
             


            }

            // Console.WriteLine("Hello World!");
        }
    }
}

