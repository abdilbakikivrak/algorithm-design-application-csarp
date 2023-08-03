
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
                        where m[0] == 'a'   // string olarak tanımlanan değerleri linq yapısı kullanarak a terimine göre seçme işlemi yaptırdık 

                        select m;

            foreach (var m in meyve) // yukarıdaki linq ile filtre yaptığım a öncelikli meyve değişkenine çektiğimiz filtre değeri çekiyor 
          //  {
                Console.WriteLine(m); // burası foreachtan sonra tek satır olduğu için süslü parantezler yazılmasa da olabilir.
          //  }                         // filtrelediğimiz şekilde veriyi alıyorum a karakteri öncelikli string veriisi 
            
            
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
