using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* DortIslem dortIslem = new DortIslem(2, 3);
             Console.WriteLine(dortIslem.Topla2());
             Console.WriteLine(dortIslem.Topla(3, 4));*/

            var tip = typeof(DortIslem);
            /*
            DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,6,7);
            Console.WriteLine(dortIslem.Topla2());
            Console.WriteLine(dortIslem.Topla(1,2));*/

            var instance = Activator.CreateInstance(tip, 6, 5);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.WriteLine("----------------------");

            var methodlar = tip.GetMethods();
            foreach (var info in methodlar)
            {
                Console.WriteLine("Method Adı: " + info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametreler: "+parameterInfo.Name);
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attributeler: "+attribute.GetType().Name);
                }
            }
            Console.ReadLine();
        }
    }

    public class DortIslem
    {
        private int _x;
        private int _y;

        public DortIslem(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int Topla(int x, int y)
        {
            return x + y;
        }

        public int Carp(int x, int y)
        {
            return x * y;
        }

        public int Topla2()
        {
            return _x + _y;
        }

        [MethodName("Carpma")]
        public int Carp2()
        {
            return _x * _y;
        }
    }

    public class MethodNameAttribute:Attribute
    {
        public MethodNameAttribute(string name)
        {

        }
    }
}
