using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance;
        private double _wbalance;
        public void Deposit(double amount)
        {
            Console.WriteLine($"Depositing {amount,0:c} into your account...");
            _balance = amount;
        }
        public void Withdraw(double sAmount)
        {
            Console.WriteLine($"Withdrawing {sAmount, 0:c}");
            _wbalance = sAmount;
        }


        public double GetBalance()
        {
            return _balance;
        }

        public double NewBalance()
        {
            return _balance - _wbalance;
        }
    }
}
