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
            Car _toyota = new Car("Toyota", "2019 XSA", "180 kmph", 1.6);
            _toyota.PrintProperties();
            Console.ReadLine();
        }
    }
}
