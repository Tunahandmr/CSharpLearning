using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add(); // Sql Server default

            MySql mySql = new MySql();
            mySql.Add(); // Added by default

            Console.ReadLine();
        }
    }

    class Database
    {
        //Virtual-> kalıtım aldığımız sınıftaki metodu ezmemiz gerektiğinde kullanabiliriz.

        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public void Delete()
        {
            Console.WriteLine("Delete by default");
        }
    }

    class SqlServer : Database
    {
        //ezme işlemi
        override public void Add()
        {

            Console.WriteLine("Sql Server default");
            // base.Add(); ->normal kodu calıstırır
        }

    }

    class MySql : Database
    {

    }
}
