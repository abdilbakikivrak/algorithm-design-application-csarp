
// kutulama ve kutudan çıkarma işlemi
/*
using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kutulma - boxing
            int i = 23;
            object o = i; // eğer tanımladığımız değişken bir başka değişken tarafından kapsanabiliyorsa buna kutulama denir.
                          // mesela burada int i değerini object nesnesi olarak da tutabildiğimizden kutulma işlemi olur.
            object o = (object) i;  //explicit boxing

            // kutudan çıkarma - unboxing
            i *= 2; // i=i*2; 
            
            i = (int)o; // cast 
            Console.WriteLine(" Deger turu: {0}", i);
            Console.WriteLine(" Referans turu: {0}", o);
        }
    }
} 
*/
/*
// sabitler uygulama 
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static const beraber kullanılmaz 
            //static const int c = 45;  yani bu şekilde kullanılmaz 
            const int c = 45;
            int sayi = 5;
            // const int c1 = 3 + sayi; const kullanırken 3+sayi dediğimizde hata verir çünkü const sabit içermesi gerekiyor 
            const int c1 = 3+  8 ; // onun yerine 8 yazarsak bir sabiti ifade edeceği için hata vermeyecektir.
           //* const int c2;
           //* c2 = 4;  // const int kullanırken sabitlere oluşturulduğu yerde değerini vermemmiz gerekiyor 
            const int c3 = 5; // doğrusu bu şekilde 
            Console.WriteLine("C degerleri : c1 :{0} \t c2: {1}", c1, c3); 
        }
    }
}
*/
/*
// var nesnesi sabitlerle uygulama sınıf ayırıp
using System;

    namespace ABK
{
     class Program
    {
        static void Main(string[] args )
        {
            var mC = new SampleClass(11, 12);
            Console.WriteLine($" x={mC.x}, y= {mC.y}"); // 
            Console.WriteLine($" C1= {SampleClass.c1},C2= {SampleClass.c2}");

        }
    }
    class SampleClass
    {
        public int x;
        public int y;

        public const int c1 = 7;
        public const int c2 = c1 + 6;

        public SampleClass(int p1, int p2)
        {
            x = p1;
            y = p2;


        }
    }
}
*/

/*
// var ile linq kullanarak string yapısında filtre seçme yapma
using System;
using System.Linq;

namespace ABK
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 23; // bu değeri örtülü bir şekilde yazmış olduk (implicitly typed)
            int y = 23; // bu değer açık yazılmış oldu (explicitly typed)
            string[] meyveler = { "elma ", "armut", "muz", "üzüm ", "seftali" };
            var meyve = from m in meyveler
                        where m[0] == 'e'   // string olarak tanımlanan değerleri linq yapısı kullanarak a terimine göre seçme(filtre) işlemi yaptırdık {0} -> ile birinci harf/karakteri kontrol ediyoruz
                        select m;
            foreach (var m in meyve)
            {
                Console.WriteLine(m); // burası foreachtan sonra tek satır olduğu için süslü parantezler yazılmasa da olabilir.
            }                             // filtrelediğimiz şekilde veriyi alıyorum a karakteri öncelikli string veriisi 
            
            // var kullanımında yapılan eşitliğin sağ tarafından gelecek ifadeyi ve yapısını bilmiyorsam ifadenin sol tarafındaki değişkenin tipinin belirlenmesini gelen veri türüne göre otomatik belirlenmesini var kullanımı ile sağlayabiliriz
            // daha sonra gelen veri türüne göre var ile tanımladığımız değeri ek bir prosedürle işleme alabiliriz
        }
    }
}

*/

/*
// kontrol ifadeleri if else if  else
using System;

namespace ABK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir karakater giriniz:");
            char ch = (char)Console.Read();

            if (char.IsUpper(ch))  // klavyeden girilen karakterin ch değeri isupper ile  büyük bir karakter mi şeklinde bir if koşul yapısı başlatıyorum
            {
                Console.WriteLine("Girilen karakter büyük karakter.");

            }
            else if (Char.IsLower(ch)) 
            {
                Console.WriteLine("Girilen karakter küçük bir kucuk karakter.");

            }
            else if (Char.IsDigit(ch))
            {
                Console.WriteLine("Girilen karakter digit yani sayıdır.");

            }
            else
            {

                Console.WriteLine("Girilen karakter turu alfanumerik bir ifadedir.");
            }
        }
    }
}

*/

/*
/// if ve else yapısının and ve or yapısıyla kullanımı 
using System;

namespace ABK
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*
            bool result = true;
            if (result)  // (!result) dediğimde sonuç true olsa bile ! olduğundan onun değilini alır
            {
                Console.WriteLine("Sonuc 1");
            }
            else // 
            {
                Console.WriteLine("Sonuc 2");
            }
          *-/
            int m = 9;
            int n = 10;
            int p = 20;

            if (p>=n && p>=m ) // iki koşulu ve operatörü ile birbirine bağladım
            {
                Console.WriteLine("En buyuk p ");
            }
            if  (p>n && !(m>p))
            {
                Console.WriteLine("En buyuk p "); // yine aynı çıktıyı alırız  
            }
            if (p>n || p>n )
            {                                             // olmazsa ekrana çıktı vermiyor
                Console.WriteLine(" p en küçük değil "); // bu uygulamada if 'ler bağımsız olarak  ayrı ayrı değerlendiriliyor else yapısı yok sağlamıyorsa geçiyor 
            }

            p = 4;

            if (!(p>n || p>m)) // iki yanlış durumu bir değil operatöru ve veya işleçi ile yine koşulu sağlar kıldım

            {
                Console.WriteLine(" p artık en kücük");
            }
        } 

    }
}
*/
/*
// switch case uygulaması 1
using System;

namespace ABK
{
    class Program
    {
        public enum Renkler {kİRMİZİ, yesil, mavi} // eğer bu değerleri =1,,2,3 diye numaralandırmazsak kendisi 0'dan başlar. integer türünde oluşurlar

        static void Main(string[] args)
        {
            Renkler r = (Renkler)(new Random()).Next(0, 50);

            switch ( r)
            {
                case Renkler.kİRMİZİ:
                    Console.WriteLine(" Renk kirmizidir.");
                    break;
                case Renkler.yesil:
                    Console.WriteLine(" Renk yesildir.");
                    break;
                case Renkler.mavi:
                    Console.WriteLine(" Renk mavidir.");
                    break;
                default:
                    Console.WriteLine(" Renk kumarhaneduvari rengindedir =).");
                    break;



            }
        }
    }
}
*/
// switch case uygulaması 2

using System;

namespace ABK
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int caseSwitch = rnd.Next(1, 5); // 1-5 arasında caseswitch değeri için sayı ürettirdik
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Durum 1");
                    break;

                case 2:
                   
                case 3:
                    Console.WriteLine($"case {caseSwitch}");
                    break;
                default:
                    Console.WriteLine($" Beklenmeyen durum {caseSwitch}");
                    break;

            }
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
