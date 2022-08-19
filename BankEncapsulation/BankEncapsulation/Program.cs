using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main()
        {
            var myAccount = new BankAccount();
            Console.WriteLine("Welcome to The Bank");
            bool correctPIN;
            do
            {
                Console.WriteLine("please enter your pin number");
                var pinAttempt = int.Parse(Console.ReadLine());
                correctPIN = myAccount.EnterPIN(pinAttempt);
            } while (!correctPIN);

            var finishedAction = false;
            do
            {
                var finishedActionATM = false;
                Console.WriteLine("please select the action you would like to perform");
                Console.WriteLine("press 1 to withdrawl, press 2 to deposit, press 3 to access account balance, and press 4 to exit");
                var accountAction = int.Parse(Console.ReadLine());

                switch (accountAction)
                {
                    case 1:
                        Console.WriteLine("please enter the amount youd like to withdraw");
                        var withdrawl = int.Parse(Console.ReadLine());
                        myAccount.Withdrawl(withdrawl);
                        break;
                    case 2:
                        Console.WriteLine("please enter the amount youd like to deposit");
                        var deposit = int.Parse(Console.ReadLine());
                        myAccount.Deposit(deposit);
                        break;
                    case 3:
                        Console.WriteLine($"your current balance is: {myAccount.GetBalance()}");
                        break;
                    case 4:
                        finishedActionATM = true;
                        break;
                }
                if (finishedActionATM == true)
                    finishedAction = true;
            } while (!finishedAction);
        }
    }
}
