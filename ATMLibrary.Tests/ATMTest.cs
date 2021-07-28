using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeLouisvilleATM;
using Xunit;

namespace ATMLibrary.Tests
{
    public class ATMTest
    {
        [Fact]
        public void CheckBalance()
        {
            Atm test = new Atm(0);
            int Balance = test.CheckBalance();
            Assert.Equal(0, Balance);

        }

        [Fact]
        public void DepositTest()
        {

            Atm test = new Atm(500);
            test.Deposit(200);
            int balance = test.CheckBalance();
            Assert.Equal(700, balance);

        }
        [Fact]
        public void WithdrawTestPass()
        {

            Atm test = new Atm(500);
            test.Withdraw(200);
            int balance = test.CheckBalance();
            Assert.Equal(300, balance);
        }

        [Fact]
        public void InvestTestPass()
        {

            Atm test = new Atm(500);
            test.StockMarketInvesting(200);          
            int balance = test.CheckBalance();
            Assert.Equal(300, balance);

        }

    }
}
