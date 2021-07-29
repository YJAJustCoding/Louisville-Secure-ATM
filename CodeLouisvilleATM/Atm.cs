using System;
using System.Media;


namespace CodeLouisvilleATM
{
    public class Atm
    {
        public SoundPlayer _soundPlayer;
        public int Balance { get; set; }

        public Atm(int balance)
        {
            Balance = balance;
        }
        public int CheckBalance()
        {
            Console.WriteLine($"Your Balance is ${Balance} dollars.");
            return Balance;
        }

        public int InvestAllMoneyInStockMarket()
        {
            _soundPlayer = new SoundPlayer("AndItsGone.wav");
            Balance = 0;
            Console.WriteLine($"Please wait while we invest your money");
            _soundPlayer.Play();
            System.Threading.Thread.Sleep(14000);
            CheckBalance();
            return Balance;
        }

        public int InvestAllMoneyInStockMarketTest()
        {  
            //Commented out the soundPlayer to UnitTest it
            //_soundPlayer = new SoundPlayer("AndItsGone.wav");
            Balance = 0;
            //_soundPlayer.Play();
            //System.Threading.Thread.Sleep(14000);
            Console.WriteLine($"and its gone!!!");
            return Balance;
        }

        public void Withdraw(int value)
        {
            //Allows you to withdraw all your money
            if (Balance - value > -1 && value > -1)
            {
                Balance -= value;
                Console.WriteLine($"Your Balance is now ${Balance} dollars");               
            }
            else
            {
                Console.WriteLine("1.You can't withdraw more money than you have \n2.Or a negative Number.");
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
                Console.WriteLine("1.Please Deposit at least 1 Dollar or more \n2.Or a negative number");
            }
        }
        public void StockMarketInvesting(int value)
        {
            if (Balance - value == 0 && value > 0)  
            {
                Balance = 0;
                Console.Write($"And its gone your Balance is now ${Balance}");
            }          
            // invest all but 1 dollar
            else if (Balance - value > 0 && value > 0)
            {
                Balance -= value;
                Console.WriteLine($"Your Balance is now ${Balance} dollars \nWe are so sorry for your loss Please Invest more!");
            }
            else
            {
                Console.WriteLine("1.You can't Invest more money than you have \nYou have to invest at least 1 dollar.");
            }
        }
    }
}