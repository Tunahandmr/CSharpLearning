using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id=1,City="Trabzon",Name="Tunahan"};
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }

    [ToTable("Customers")] // customers tablosuna karşılık gelir
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        public string City { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Add'i kullanma, AddNew'i kullan")]//hazır attribute, uyarı verir.
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!!",
                customer.Id,customer.Name,customer.LastName,customer.City);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!!",
                customer.Id, customer.Name, customer.LastName, customer.City);
        }
    }

    // [AttributeUsage(AttributeTargets.All)] bu attribute herkes kullanabilir
    // [AttributeUsage(AttributeTargets.Class)] bu attribute sınıflar kullanabilir
    //[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)] bu attribute property ve field'lar kullanabilir
    [AttributeUsage(AttributeTargets.Property,AllowMultiple =true)]// AllowMultiple =true -> attribute ard arda kullanilabilir 
    class RequiredPropertyAttribute :Attribute 
    {

    }

    [AttributeUsage(AttributeTargets.Class)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
