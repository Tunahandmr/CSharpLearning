using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] worker = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()

            };

            foreach (var works in worker)
            {
                works.Work(); //bütün herkese çalış demiş olduk.
            }

            IEat[] eat = new IEat[2]
            {
                new Manager(),
                new Worker()
               //Robot'un eat özelliği olmadığı için onu ekleyemedik.
            };

            foreach(var item in eat)
            {
                item.Eat();
            }
            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }


}
