using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {

        static void Main(string[] args)
        {
            CashRegister register1 = new CashRegister("CR1");
            CashRegister register2 = new CashRegister();
            //Store store = new Store();
            //store.AddCashRegister(register1);
            //store.AddCashRegister(register2);

            register1.AddItem(58.5);
            register1.AddItem(5.9);
            register1.AddItem(5.5);
            register1.AddItem(18);
            register1.AddItem(5.59);

            register2.AddItem(52.5);
            register2.AddItem(15.5);
            register2.AddItem(53.5);
            register2.AddItem(544.5);

            Console.WriteLine();
            PrintReport(register1);

            Console.WriteLine();
            register2.Name = "CR2";
            PrintReport(register2);
            Console.WriteLine();

            //store.PrintReport();
            PrintStoreReport();
            Console.ReadLine();
        }

       static void AddItem(CashRegister register , double price)
       {
            register.AddItem(price);

       }
        private static void PrintReport(CashRegister register)
        {
            Console.WriteLine("Total cash in {0} is: {1:C} ", register.Name, register.GetTotalCash());
            Console.WriteLine("Total Items count in {0} is: {1} ", register.Name, register.GetTotalItems());
        }

        private static void PrintStoreReport()
        {
            Console.WriteLine();
            Console.WriteLine("Total cash in {0} Cash registers : {1:c} ", 2, CashRegister.TotalCashAllReg);
            Console.WriteLine("Total Items count in {0} Cash registers is: {1} ", 2, CashRegister.totalItemsAllReg);
        }
    }
}
