using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prime(21);
            Console.ReadLine();
        }

        static void Prime(int number)
        {

            bool b = false;  

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    b = true;
                    break;
                }

            }
            if (b)
            {
                Console.WriteLine("asal değil");
            }
            else
            {
                Console.WriteLine("asal");
            }

        }
    }
}
