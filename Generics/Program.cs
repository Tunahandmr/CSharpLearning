using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> list = utilities.BuildList<string>("Ankara", "Trabzon", "İzmir");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            List<Customer> result = utilities.BuildList<Customer>(new Customer { FirstName = "Tunahan" }, new Customer { FirstName = "Ahmet" });
            foreach (Customer customer in result) { Console.WriteLine(customer.FirstName); }
            Console.ReadLine();
        }
    }

    class Utilities
    {
        // sayı belirsiz olduğu için params
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
    class Product
    {

    }

    class Customer
    {
        public string FirstName { get; set; }
    }

    interface IProductDal : IRepository<Product>
    {

    }
    interface ICustomerDal : IRepository<Customer>
    {
    }
    interface IEntity
    {

    }

    interface IRepository<T> where T : class,
        // IEntity,
        //struct, ->  değer tip yazmaya izin verir
         new()//class-> referans tip olması gerekliliği int yazılmaya karşı,new()-> newlenebilir bir tür yazılabilir string yazılmaya karşı,IEntity-> IEntity'den implement edilmesi gerekir
    {
        List<T> GetAll();

        T Get(int id);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
