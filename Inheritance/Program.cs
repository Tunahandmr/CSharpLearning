using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //her class sadece 1 class'tan kalıtım alabilir.


            Customer customer = new Customer();
            customer.Name = "Tunahan";

            Person[] persons = new Person[3]
            {
                new Person{ Name="Tunahan"},new Customer{ Name="Ahmet"},new Student{ Name="Burak" } };

            foreach (var item in persons)
            {
                Console.WriteLine(item.Name); 
            }

            Console.ReadLine();

        }
    }

    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

    }

    class Customer:Person
    {
       //Customer'dan oluşturacağımız nesnemiz person'ın özelliklerini de taşıyacak
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
