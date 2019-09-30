using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount("S00189636", "Mohamed", "500");
            myAccount.PrintAccountDeteils();

            myAccount.withdraw(10);
            myAccount.PrintAccountDeteils();

            BankAccount hisAccount = new BankAccount("S00189656", "Adil", "1500");
            myAccount.TransferFrom(hisAccount, 500);
            hisAccount.PrintAccountDeteils();
            myAccount.PrintAccountDeteils();
            Console.ReadLine();
        }
    }
}
