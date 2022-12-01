using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //private-> tanımlandığı blok içerisinde çagrılabilir.
            //default private'tir.

            //protected-> private'in tüm özelliklerini karşılar, artı olarak inheritance edildiği sınıftan da çağrılabilir.

            //class'ların default'u internal'dır.
            //internal-> o proje içerisinde her yerden çağrılmasını sağlar.

            //public-> diğer projelerden de çağrılabilmesini sağlar.
            //bunun için hangi projede çağıracaksak 'using AccessModifiers'ı implement edip,çağıracağımız şeyi public yapmak yeterlidir.
            Console.ReadLine();
        }

       
    }

    
    
}
