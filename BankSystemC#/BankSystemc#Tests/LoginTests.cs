using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankSystemc_.Tests
{
    
    [TestClass()]
    public class LoginTests
    {
        private Login _login;

        [TestInitialize]
        public void Setup()
        {
            _login = new Login(true); // Skip resource initialization
        }

        [TestMethod()]
        public void GenerateOTPTest()
        {
            // Act
            var (otp, timestamp) = _login.GenerateOTP();

            // Assert
            Assert.AreEqual(6, otp.Length, "OTP should be 6 digits long.");
            Assert.IsTrue(int.TryParse(otp, out _), "OTP should be numeric.");
        }
    }

}
