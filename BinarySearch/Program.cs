using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] dizi = new int[10];

            Random random = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
               
                dizi[i] = random.Next(1, 10);

            }

            int[] siralidizi = DiziSirala(dizi);
            

            int indis = ArananSayiIndex(siralidizi, 5);
            Console.WriteLine(indis);

            Console.ReadLine();
        }

        static int ArananSayiIndex(int[] siralidizi, int aranandeger)
        {
            int ilkindex = 0;
            int sonindex = siralidizi.Length - 1;
            int ortaindex;
            while (ilkindex <= sonindex)
            {
                ortaindex = (ilkindex + sonindex) / 2;

                if (siralidizi[ortaindex] > aranandeger)
                {
                    sonindex = ortaindex - 1;
                }
                else if (siralidizi[ortaindex] < aranandeger)
                {
                    ilkindex = ortaindex + 1;

                }
                else
                {
                    return ortaindex;

                }


            }
            return -1;


        }



        static int[] DiziSirala(int[] dizi)
        {
            //kabarcık sıralama
            int tmp;
            Console.WriteLine("*****");
            int dongusayisi = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                for (int xx = i; xx < dizi.Length; xx++)
                {
                    if (dizi[i] > dizi[xx])
                    {
                        tmp = dizi[i];
                        dizi[i] = dizi[xx];
                        dizi[xx] = tmp;
                    }
                    dongusayisi++;

                }

            }
            return dizi;

        }
    }
}
