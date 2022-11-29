using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //interface'ten nesne oluşturulamaz.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());

            //-------------------------------------------------------------------

            PersonManager personManager = new PersonManager();
            Customer customer = new Customer { Id = 1, FirstName = "tunahan", Address = "trabzon", LastName = "demir" };
            personManager.Add(customer);

            Student student = new Student
            {
                Id = 1,
                FirstName = "tuna",
                LastName = "demir",
                Departmant = "Computer Engineering"
            };
            personManager.Add(student); //fonksiyonda interface türünde istediğim için kızmadı.

            //------------------------------------------------------------------------------

            CustomerInterface[] customerArray = new CustomerInterface[3]
            {
                new SqlServerCustomerDAl(),
                new OracleCustomerDal(),
                new MysqlCustomerDal()


            };

            foreach (var item in customerArray)
            {
                item.Add();
            }

            Console.ReadLine();
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //ortak ozellikleri aldık, sınıfa ozel ozellik te ekleyebildik.
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //ortak ozellikleri aldık, sınıfa ozel ozellik te ekleyebildik.
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
