using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Lunch mohLunch = new Lunch("Burger");
            Lunch mohLunch1 = new Lunch("Pizza");
            Lunch mohLunch2 = new Lunch("hot dog");

            PrintLunch(mohLunch, mohLunch1);
            Console.WriteLine();
            PrintLunch(mohLunch2);

            Console.WriteLine();
            PrintLunch(mohLunch1,mohLunch,mohLunch2);

            Console.ReadLine();

        }

        static void PrintLunch(params Lunch[] lunchItems)
        {
            string format = "{0,-20}{1,-10}{2}";
            Console.WriteLine(format,"Entree","Side","Drink");

            foreach (Lunch item in lunchItems)
            {
                Console.WriteLine(format, item.Main, item.side, item.drink);
            }
        }
    }
}
