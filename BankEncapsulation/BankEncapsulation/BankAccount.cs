using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;
        private readonly int _pin = 1234;
        private bool _locked = true;
        public bool EnterPIN(int pin)
        {
            if (_pin == pin)
            {
                _locked = false;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Deposit(double amount)
        {
            if (_locked != false)
                Console.WriteLine("sorry you cannot access this account");
            else _balance += amount;
        }
        public void Withdrawl(double amount)
        {
            if (_locked != false)
                Console.WriteLine("sorry you cannot access this account");
            else _balance -= amount;
        }
        public string GetBalance()
        {
            if (_locked != false)
                return "sorry you cannot access this account";
            else return _balance.ToString();
        }
    }
}

