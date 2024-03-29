﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class CashRegister
    {

        static public double TotalCashAllReg;
        static public  int totalItemsAllReg;
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
            Console.WriteLine("Adding an Item worth {0:C} to the {1}", price, Name);
            totlaItems++;
            totalCash += price;
            totalItemsAllReg++;
            TotalCashAllReg += price;
        }

        public double GetTotalCash()
        {
            return totalCash;
        }

        public string GetTotalItems()
        {
            return totlaItems.ToString();
        }

    }
}
