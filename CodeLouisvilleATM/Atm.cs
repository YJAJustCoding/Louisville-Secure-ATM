using System;

namespace CodeLouisvilleATM
{
    public class Atm
    {
        public int Balance { get; set; }
        
        //public string Username { get; set; }
        
        //public int Pin { get; set; }

        public Atm(int balance)
        {
            Balance = balance;
        }

        public int CheckBalance()
        {
            Console.WriteLine($"Your Balance is ${Balance} dollars.");
            return Balance;
        }
        public void Withdraw(int value)
        {
            //Allows you to withdraw all your money
            if (Balance - value > -1 )
            {
                Balance -= value;
                Console.WriteLine($"Your Balance is now ${Balance} dollars");
            }
            else
            {
                Console.WriteLine("You can't withdraw more money than you have.");
            }
        }

        public void Deposit(int value)
        { if (value > 0)
            {
                Balance += value;
                Console.WriteLine($"Your Balance is now ${Balance}");
            }
            else
            {
                Console.WriteLine("Please Deposit at least 1 Dollar or more");
            }
        }
        // public Void StockMarketInvesting()
        //{
        // balance = 0;
        //  Console.WriteLine($"And its gone!!!!! your balance is now ${Balance} )
        //}
        //
        public void StockMarketInvesting(int value)
        {
            if (Balance - value == 0)  
            {
                Balance = 0;
                Console.Write($"And its gone your Balance is now ${Balance}");
            }
            
            // invest all but 1 dollar
            else if (Balance - value > 0)
            {
                Balance -= value;
                Console.WriteLine($"Your Balance is now ${Balance} dollars \nWe are so sorry for your loss Please Invest more!");
            }
            else
            {
                Console.WriteLine("You can't Invest more money than you have.");
            }
        }
    }
}