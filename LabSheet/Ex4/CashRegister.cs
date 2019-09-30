using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class CashRegister
    {
        private int totlaItems;
        private double totalCash;
        public string Name { get; set; }

        public CashRegister()
        {
            totalCash = 0;
            totlaItems = 0;
            Name = "No Name CR";
        }
        public CashRegister(string name)
        {
            totalCash = 0;
            totalCash = 0.0;
            Name = name;
        }

        public void AddItem(double price)
        {
            Console.WriteLine("Adding an Item worth {0:C} to the {1}",price,Name);
            totlaItems++;
            totalCash += price;
        }

        public string GetTotalCash()
        {
            return String.Format("{0:C}",totalCash);
        }

        public string GetTotalItems()
        {
            return totlaItems.ToString();
        }

    }
}
