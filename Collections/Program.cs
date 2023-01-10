using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayLists();
            //Lists();

            //Anahtar-Değer eşleşmesi
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Elma");
            dictionary.Add(2, "Armut");
            dictionary.Add(3, "Kiraz");

            Console.WriteLine(dictionary[2]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }
            Console.ReadLine();

        }

        private static void Lists()
        {
            //tip güvenli koleksiyonlar
            List<string> list = new List<string>();
            list.Add("Adana");
            list.Add("Trabzon");

            string[] dizi = new string[2] { "Mersin", "Antalya" };

            //Listeye dizi eklemek için kullanılır
            list.AddRange(dizi);

            //list'te Ankara değeri varsa true döner
            Console.WriteLine(list.Contains("Ankara"));

            //0. indexe ağrı ekle
            list.Insert(0, "Ağrı");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id=1,FirstName="Tunahan"});
            //customers.Add(new Customer { Id = 2, FirstName = "Hasan" });



            List<Customer> customers = new List<Customer>() {
                new Customer { Id = 1, FirstName = "Tunahan" },
                new Customer { Id = 2, FirstName = "Hasan" }
            };

            //listenin eleman sayısı
            var count = customers.Count();

            customers.AddRange(new Customer[2] { new Customer { Id = 3, FirstName = "Ali" },
            new Customer { Id = 4, FirstName = "Ahmet" }});

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            //listedeki bütün elemanları temizler
            customers.Clear();
        }

        private static void ArrayLists()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('a');

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
