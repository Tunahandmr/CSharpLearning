using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Add();

            var result = Add2(12, 28);
            Console.WriteLine(result);

            //-----ref-----
            int number1 = 20;
            int number2 = 30;

            int r = Add3(ref number1, number2);
            Console.WriteLine(r);
            //referans tip olarak gönderdiğimiz için number1 in deeri değişmiş oldu.
            Console.WriteLine(number1);
            

            //-----Params-----
            Console.WriteLine(Add5(1,2,3,4,5,6));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int n1, int n2) { return n1 + n2; }

        static int Add3(ref int n1, int n2)
        {
            n1 = 40;
            return n1 + n2;
        }

        static int Add4(out int n1, int n2)
        {
            //out -> mantığı ref ile aynı,değişken için ref'te başlangıç değeri gerekirken out'ta gerekmez.Ancak metodun
            //içinde init edilmesi gerekir.
            n1 = 40;
            return n1 + n2;
        }

        static int Add5(int  number,params int[] numbers)
        {
            //params -> sınırsız overloading
            //params metodun son parametresi olmak zorunda
            return numbers.Sum();
        }
    }
}
