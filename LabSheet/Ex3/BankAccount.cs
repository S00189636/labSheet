using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{

    class BankAccount
    {
        string AccountNumber;
        string AccountHolder;
        double Balance;

        public BankAccount() { }
        public BankAccount(string accountNumber,string accountHolder,string balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = double.Parse(balance);
        }

        public string GetBalance()
        {
            string bal = String.Format( "{0,-10:C}", Balance);
            return bal;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("Success\n your balance is {0}", GetBalance());
        }

        public bool withdraw(double amount)
        {
            bool success = false;
            if (amount <= Balance)
            {
                amount *= -1;
                Deposit(amount);
                success = true;
            }
            else Console.WriteLine("Non-sufficient funds");
            return success;
        }

        public void PrintAccountDeteils()
        {
            string format = "{0,-25}{1,-10}";
            Console.WriteLine(new string('-', 35));
            Console.WriteLine(format,"Account number:",AccountNumber);
            Console.WriteLine(format,"Account holder:",AccountHolder);
            Console.WriteLine(format,"Balance:",GetBalance());
            Console.WriteLine(new string('-',35));
        }


        public void TransferFrom(BankAccount account,double amount)
        {
            if (account.withdraw(amount))
            {
                Deposit(amount);
            }
        }
    }
}
