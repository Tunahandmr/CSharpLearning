using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //stringler bir char array'idir.
            string city = "Ankara";
            Console.WriteLine(city[0]); //A yazdırır.

            foreach (var item in city)
            {
                //yukarıdan aşağı doğru Ankara yazdırır.
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            //-----string birleştirme-----

            //1.yol
            string r = city + city2;

            //2.yol
            Console.WriteLine(String.Format("{0} {1}", city, city2));

            //-----string metodlar-----

            string sentence = "My name is Tunahan";

            var result = sentence.Length; // cümlenin uzunluğu

            //ifadeyi klonlar ifadenin değeri değiştiğinde klon bundan etkilenmez.
            var resultClone = sentence.Clone();
            sentence = "My lastname is Demir";
            Console.WriteLine(resultClone); //ekranda My name is Tunahan , yazdıracaktır.

            bool result2 = sentence.EndsWith("g"); //g ile mi bitiyor.
            bool result3 = sentence.StartsWith("My name"); //My name ile mi başlıyor.


            var result4 = sentence.IndexOf("name"); // name kaçıncı elemanda başlıyor.Elemandan birden çok varsa ilk
            //karşılaştığını ele alır.

            var result5 = sentence.LastIndexOf(""); //elemanı sondan başa doğru arar ancak vereceği sayıyı baştan sayım olarak yazar.

            var result6 = sentence.Insert(0, "Hello"); // 0. karaktere Hello ekle

            var result7 = sentence.Substring(3); //3. karakterden öncesini kes, sonrasını al
            var result8 = sentence.Substring(3, 4); //3. karakterden itibaren 4 karakterlik cümle al

            var result9 = sentence.ToLower(); //cümledeki bütün harfleri küçük yapar.
            var result10 = sentence.ToUpper(); //cümledeki bütün harfleri büyük yapar.

            var result11 = sentence.Replace(" ", "-"); //Cümledeki boşluğu çizgi ile değiştir.
            var result12 = sentence.Remove(2); //2. karakterden sonrasını çöpe at.
            var result13 = sentence.Remove(2, 5); //2'den itibaren 5 karakteri çöpe at.
            Console.ReadLine();
        }
    }
}
