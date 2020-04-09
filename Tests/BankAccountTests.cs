using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecondRepoCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecondRepoCore.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DebitTest()
        {
            BankAccount ba = new BankAccount("ddd", 0);
            ba.Debit(222);
            
        }
    }
}