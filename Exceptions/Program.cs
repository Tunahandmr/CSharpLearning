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
            //TryCatch();

            //ActionDemo();

            Func<int, int, int> add = Topla;
            Console.WriteLine(add(2, 3));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            Console.WriteLine(getRandomNumber());

            Func<int> getRandomNumber2 = ()=> new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2());
            Console.ReadLine();
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            HandleException(() =>
            {
                Find();
            });
        }

        private static void TryCatch()
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
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }

        private static void Find()
        {
            List<string> student = new List<string> { "Tunahan", "Ali", "Hasan" };
            if (!student.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record not found!");
            }
            else
            {
                Console.WriteLine("Record found");
            }
        }

    }
}
