using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankaccont_ovning
{
    public class Bankaccont
    {
        private int balance;


        // Det här är en konstruktor som sätter startvärdet på balance.
        public Bankaccont(int Balance)
        {
            balance = Balance;


        }

        // Det är en metod som plussar på ett värde till balance.
        public void Deposit(int amount)
        {
            Console.WriteLine("Du har satt in: " + amount);
            balance += amount;



        }

        // Detta är metodonen för att dra av eller uttåg från kontot.
        public void Withdraw(int amount)
        {
            Console.WriteLine("Du har tagit ut: " + amount);
            balance -= amount;
        }

        // Det här är en metod för att kolla saldot på kontot.
        public int GetBalance()
        {
            return balance;


        }
        // Det här är en metod som visar insättning, uttåg och saldo.
        public void ShowBalance()
        {
            Console.WriteLine($"Saldo: {GetBalance()}");
        }

    }
}
