using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchDemo
{
    class Lunch
    {
        static Random rand = new Random();
        string[] sideDishes = new string[] { "Frise", "Chips", "Salad", "Cookie", "Fruit cup" };
        string[] drinks = new string[] { "Water", "Milk", "Iced tea", "Cola", "Lemonada" };
        public string Main { get; private set; }
        public string side;
        //{
        //    get
        //    {
        //        return sideDishes[rand.Next(0, sideDishes.Length)];
        //    }
        //}
        public string drink;
        //{
        //    get
        //    {
        //        int test = rand.Next(0, drinks.Length);
        //        Console.WriteLine(test.ToString());
        //        return drinks[test];
        //    }
        //}

        public Lunch(string mainDish)
        {
            Main = mainDish;
            side = sideDishes[rand.Next(0, sideDishes.Length)];
            drink = drinks[rand.Next(0, drinks.Length)];
        }

    }
}
