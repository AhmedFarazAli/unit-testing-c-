using System;
using Bank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// https://github.com/AhmedFarazAli

namespace BankTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //https://github.com/AhmedFarazAli
        }

        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            
            // https://github.com/AhmedFarazAli

            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Ahmed Faraz Ali", beginningBalance);

            //https://github.com/AhmedFarazAli

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }
    }
}
