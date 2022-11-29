using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[5];

            //dizinin içini random sayılar ile dolduruyoruz.

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 99);
            }


            //dizinin elemanlarını dönüyoruz.

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    var num = array[j + 1];
                    if (array[j] > array[j + 1])
                    {
                        array[j + 1] = array[j];
                        array[j] = num;

                    }
                }


            }

            //elemanları ekrana yazdırıyoruz.

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
