using System;

namespace MyFirstApp
{
    public class BankAccount
    {
        private decimal _balance;

        public decimal Balance
        {
            get { return _balance; }
            private set
            {
                if(value > 0)
                    _balance = value;
                else
                    Console.WriteLine("Balance cannot be negative.");
            }
        }

        public BankAccount()
        {
            Balance = 0m;
        }

        public BankAccount(decimal initialBalance)
        {
            if (initialBalance >= 0)
                Balance = initialBalance;
            else
            {
                Console.WriteLine("Initial balance cannot be negative");
                Balance = 0m;
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Successfully deposited {amount:C} Shillings. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount cannot be negative");
            }
        }

        public void Withdraw(decimal amount)
        {
            if ((Balance > amount) && (amount > 0))
            {
                Balance -= amount;
                Console.WriteLine($"Successfully withdrew {amount:C} Shillings! New Balance: {Balance:C}");
            }
            else if (Balance < amount)
                Console.WriteLine("You have insufficient funds!");
            else
                Console.WriteLine("Withdraw amount must be positive!");

        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Your Balance is {Balance:C} Shillings");
        }
    }
}
