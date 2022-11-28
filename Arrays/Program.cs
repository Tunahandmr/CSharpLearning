using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Kullanım
            string[] students = new string[3];
            students[0] = "engin";
            students[1] = "derin";
            students[2] = "salih";

            //2. Kullanım
            string[] students2 = new[] { "engin", "derin", "salih" };

            //3. Kullanım
            string[] students3 = { "engin", "derin", "salih" };

            //4. Kullanım
            string[] students4 = new string[3] { "engin", "derin", "salih" };

            //-----çok boyutlu diziler-----

            //5 satır 3 sütunluk dizi
            string[,] regions = new string[5, 3]
            {
                { "İstanbul","Kocaeli","Tekirdağ"},
                { "Ankara","Konya","Eskişehir"},
                { "Trabzon","Rize","Samsun"},
                { "İzmir","Manisa","Muğla"},
                { "Antalya","Adana","Muğla"}
               
            };

            //GetUpperBound(0)-> satırların eleman sayısı
            //GetUpperBound(1)-> sütunların eleman sayısı

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
            }

            //for each'te döndüğümüz veriyi değiştiremiyoruz

            Console.ReadLine();
        }
    }
}
