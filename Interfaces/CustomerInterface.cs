using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
     interface CustomerInterface
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDAl : CustomerInterface
    {
        public void Add()
        {
            Console.WriteLine("sql added");
        }

        public void Delete()
        {
            Console.WriteLine("sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("sql update");
        }
    }

    class OracleCustomerDal : CustomerInterface
    {
        public void Add()
        {
            Console.WriteLine("oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("oracle update");
        }
    }

    class MysqlCustomerDal : CustomerInterface
    {
        public void Add()
        {
            Console.WriteLine("Mysql added");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Mysql update");
        }
    }

    class CustomerManager
    {
        public void Add(CustomerInterface customerDal)
        {
            customerDal.Add();
        }
    }

}
