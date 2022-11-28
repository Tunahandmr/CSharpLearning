using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionBlocks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = 15;
            //------------------------------------------

            if (number < 0)
            {
                Console.WriteLine("negative");
            }
            else if (number == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine("positive");
            }

            //--------------------------------------------
            //doğru ise ilk kısım,yanlış ise ikinci kısım çalışır.

            Console.WriteLine(number == 15 ? "number is 15" : "number is not 19");

            //--------------------------------------------

            switch (number)
            {
                case 10:
                    Console.WriteLine("number is 10");
                    break;
                case 15:
                    Console.WriteLine("number is 15");
                    break;
                default:
                    Console.WriteLine("number is not 10 or 15");
                    break;
            }

            Console.ReadLine();
        }
    }
}
