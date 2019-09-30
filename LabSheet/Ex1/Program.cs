using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car _toyota = new Car("Toyota", "2019 XSA", 180, 1.6);
            Car _tesla = new Car("Tesla", "2018 Super", 280, 2.4);
            _toyota.PrintProperties();
            _tesla.PrintProperties();
           
            for (int i = 0; i < 10; i++)
            {
                _toyota.Accelerate();
            }

            _toyota.PrintProperties();
            Console.ReadLine();
        }
    }
}
