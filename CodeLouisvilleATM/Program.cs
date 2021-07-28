using System;
using System.Text;

    namespace CodeLouisvilleATM
{
    class Program
    {
        static void Main(string[] args)
        {
           //Keeps the menu going while true
            bool menu = true;
            //Initializes the ATM with $1000
            Atm atm = new Atm(1000);
                    do 
                    {   // ATM Menu
                        Console.WriteLine("\nWhat would you like to do?");
                        Console.WriteLine("1. Check your balance");
                        Console.WriteLine("2. Withdraw from ATM");
                        Console.WriteLine("3. Deposit Into ATM");
                        Console.WriteLine("4. Invest in the Stock market from your ATM!");
                        Console.WriteLine("5. Close ATM");

                      string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        atm.CheckBalance();
                        break;

                    case "2":
                        Console.WriteLine("How much would you like to withdraw?");
                        try
                        {
                            int moneyWithdrawn = Convert.ToInt32(Console.ReadLine());


                            Console.WriteLine($"You withdrew ${moneyWithdrawn}");
                            atm.Withdraw(moneyWithdrawn);
                        }
                        catch
                        {
                            var Log = new Logger();
                            Log.Log("Not a valid Withdraw amount, please input a positive Integer");
                        } 
                        break;
                            case "3":
                                Console.WriteLine("How much would you like to deposit?");
                        try
                        {
                            int moneyDeposited = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"You have deposited ${moneyDeposited}");
                            atm.Deposit(moneyDeposited);
                        }
                        catch
                        {
                            
                        {
                            var Log = new Logger();
                            Log.Log("Not a valid Deposit amount, please input a positive Integer");
                        }
                }
                                break;                        
                            case "4":
                                Console.WriteLine("How much would you like to Invest?");
                        try
                        {
                            int moneyInvested = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"You have Invested ${moneyInvested}");
                            atm.StockMarketInvesting(moneyInvested);
                        }
                        catch {
                            var Log = new Logger();
                            Log.Log("Not a valid Investment amount, please input a positive Integer");
                        }
                                break;
                            
                            case "5":
                                menu = false;
                                break;
                            default:
                                Console.WriteLine("Please choose option 1-5.");
                                break;
                         }
            } while (menu) ;
        }
    }
}
