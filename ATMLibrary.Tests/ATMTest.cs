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
    {//Code Louisville Req 4/4 the unit atleast 3 unit tests
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
        public void DepositTestFail()
        {
            //Testing for deposit of a negative number
            Atm test = new Atm(500);
            test.Deposit(-1);
            int balance = test.CheckBalance();
            Assert.NotEqual(501, balance);

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
        public void WithdrawOverBalance()
        {

            Atm test = new Atm(200);
            test.Withdraw(201);
            int balance = test.CheckBalance();
            Assert.NotEqual(-1, balance);

        }

        [Fact]
        public void WithdrawNegativeNumber()
        {

            Atm test = new Atm(200);
            test.Withdraw(-1);
            int balance = test.CheckBalance();
            Assert.NotEqual(201, balance);

        }


        [Fact]
        public void InvestTestPass()
        {

            Atm test = new Atm(500);
            test.StockMarketInvesting(200);          
            int balance = test.CheckBalance();
            Assert.Equal(300, balance);
           
        }
        [Fact]
        public void InvestOverBalanceFail()
        {

            Atm test = new Atm(500);
            test.StockMarketInvesting(501);
            int balance = test.CheckBalance();
            Assert.NotEqual(-1, balance);
        }

        [Fact]
        public void InvestNegativeNumberFail()
        {

            Atm test = new Atm(500);
            test.StockMarketInvesting(-1);
            int balance = test.CheckBalance();
            Assert.NotEqual(501, balance);
        }

    }
}
