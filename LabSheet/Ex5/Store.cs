using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Store
    {
        private List<CashRegister> cashRegisters;
        private string totlaItems
        {
            get
            {
                int total = 0;
                foreach (CashRegister cr in cashRegisters)
                {
                    total += int.Parse(cr.GetTotalItems());
                }
                return total.ToString();
            }
        }
        private string totalCash
        {
            get
            {
                double total = 0;
                foreach (CashRegister cr in cashRegisters)
                {
                    total += cr.GetTotalCash();
                }
                return total.ToString();
            }
        }

        public Store() { cashRegisters = new List<CashRegister>(); }
        public Store(CashRegister cashRegister)
        {
            cashRegisters = new List<CashRegister>();
            AddCashRegister(cashRegister);
        }

        public void AddCashRegister(CashRegister cashRegister)
        {
            cashRegisters.Add(cashRegister);
        }

        public void PrintReport()
        {
            Console.WriteLine("Total cash in {0} Cash registers : {1} ", cashRegisters.Count ,totalCash);
            Console.WriteLine("Total Items count in {0} Cash registers is: {1} ", cashRegisters.Count, totlaItems);
        }
    }
}
