using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] dizi = new string[2] { "Ahmet", "Hasan" };
                dizi[3] = "Ali";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadLine();
        }
    }
}
