using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.Add();

            Product product = new Product { Id = 1, Name = "tunahan" };
            Product product2 = new Product(2, "Tunahan2");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("tunahan3");
            personManager.Add();

            //static
            Teacher.Age = 25;

            Utilities.Validate();

            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count = 15;

        //constructor
        public CustomerManager()
        {

        }

        //constructor overloading
        public CustomerManager(int count)
        {
            _count = count;
        }

        public void List()
        {
            Console.WriteLine("Listed");
        }

        public void Add()
        {
            Console.WriteLine("Added {0} items", _count);
        }
    }

    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("logged to database");

        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("logged to file");

        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("added!");
        }
    }


    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity):base(entity)
        {
            //BaseClass constructor'ına aracılık ediyor
        }

        public void Add()
        {
            Message();
            Console.WriteLine("Added!");
        }
    }

    static class Teacher
    {
        //static sınıfın içindekiler de static olmalı
        //static nesneler new'lenemez, ortaktır herkes onu kullanabilir.
        public static int Age { get; set; }
    }

    static class Utilities
    {
        static Utilities()
        {
            //static constructor
        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        //class static olmayıp içindeki üyeler static olabilir.
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Done2");
        }
    }
}
