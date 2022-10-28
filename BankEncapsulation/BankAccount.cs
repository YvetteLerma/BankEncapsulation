using System;
namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount(double amount)
        {
            _balance = amount;
        }

        private double _balance = 0;

        //define a method named deposit that will accept a double
        //and store that value in the balance field

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw( double amount)
        {
            _balance -= amount;
        }

        public double GetBalance()
        {
            return _balance;
        }

    }
}

