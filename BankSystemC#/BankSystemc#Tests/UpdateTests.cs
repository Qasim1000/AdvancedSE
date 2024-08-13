using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankSystemc_;
using System;

namespace BankSystemc_.Tests
{
    [TestClass()]
    public class UpdateTests
    {
        private Update _updateForm;

        [TestInitialize]
        public void Setup()
        {
            _updateForm = new Update(true); // Initialize the form
            _updateForm.accounttype.Items.Add("Personal"); // Initialize items if needed
        }

        [TestCleanup]
        public void Cleanup()
        {
            _updateForm?.Dispose(); // Dispose only if _updateForm is not null
        }

        [TestMethod()]
        public void UpdateAccountNumber_ValidAccountType_UpdatesAccountNumber()
        {
            // Arrange
            _updateForm.accounttype.SelectedItem = "Personal"; // Set the selected item

            // Act
            _updateForm.UpdateAccountNumber();

            // Assert
            Assert.IsTrue(_updateForm.accountnumber.Text.StartsWith("abl"),
                "Account number should start with 'abl' for Personal accounts.");
        }
    }
}
