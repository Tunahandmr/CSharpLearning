using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // void ve parametresi olmayan metodlara elçilik yapar.
    public delegate void MyDelegate();
    // void ve string parametresi olan metodlara elçilik yapar.
    public delegate void MyDelegate2(string text);

    public delegate int MyDelegate3(int number1, int number2);
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            // customerManager.SendMessage();
            // customerManager.ShowAlert();

            //delegate ile yapacağımız işleri sıralayabiliyoruz.
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert; // ShowAlert'ı sıraya ekledik
            myDelegate -= customerManager.SendMessage; // SendMessage'ı çıkardık 
            myDelegate();

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("hello");// ikisine de aynı değeri yolluyor

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3+= matematik.Carp;
            var sonuc = myDelegate3(2,5); // çıktı-> 10
            // return olduğunda son işlem sonucu delege edilir.
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
