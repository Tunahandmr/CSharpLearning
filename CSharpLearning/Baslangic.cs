using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    internal class Baslangic
    {
        static void Main(string[] args)
        {
            int num = 123;
            Console.WriteLine("my int number: {0}", num);

            char c = 'a';
            Console.WriteLine("char: {0}", (int)c);

            var name = "tunahan";
            //name = 11;-> dersem hata verir çünkü name değişkenini string olarak algıladı.
            name = "ahmet";

            Console.WriteLine("Days: {0}", Days.Monday);
            Console.WriteLine("Days: {0}", (int)Days.Monday);

            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
