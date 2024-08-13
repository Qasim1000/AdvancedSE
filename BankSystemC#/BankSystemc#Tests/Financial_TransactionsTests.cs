using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankSystemc_;
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace BankSystemc_.Tests
{
    [TestClass()]
    public class Financial_TransactionsTests
    {
        private Financial_Transactions _financialTransactions;
        private SqlConnection _mockConnection;

        [TestInitialize]
        public void Setup()
        {
            _financialTransactions = new Financial_Transactions(true);
            _mockConnection = new SqlConnection("Data Source=DESKTOP-K8BIO91\\SQLEXPRESS;Initial Catalog=BankSystem;Integrated Security=True");
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Any necessary cleanup after tests
        }
        [TestMethod()]
        public void DepositTest()
        {
            // Arrange
            string accountNumber = "123456";
            decimal amount = 1000;
            _financialTransactions.conn = _mockConnection;

            // Act
            _financialTransactions.Deposit(accountNumber, amount);

            // Assert
            // This will depend on your mock setup. You can verify that the database call was made correctly.
            // For example, you could check that the balance in the database increased.
        }
        [TestMethod()]
        public void WithdrawTest()
        {
            // Arrange
            string accountNumber = "123456";
            decimal amount = 500;
            _financialTransactions.conn = _mockConnection;

            // Act
            _financialTransactions.Withdraw(accountNumber, amount);

            // Assert
            // Similar to the Deposit test, check that the balance in the database decreased.
        }
        [TestMethod()]
        public void TransferTest()
        {
            // Arrange
            string fromAccount = "123456";
            string toAccount = "654321";
            decimal amount = 200;
            _financialTransactions.conn = _mockConnection;

            // Act
            _financialTransactions.Transfer(fromAccount, toAccount, amount);

            // Assert
            // Verify that the amount was deducted from fromAccount and added to toAccount.
        }


    }
}
