using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallet.Domain.Entities;

namespace wallet.Test.Domain.Entities
{
    public class AccountTest
    {
        [Theory]
        [InlineData(0, 1, 1, 100, "CustomerId must be greater than 0")]
        [InlineData(1, 0, 1, 100, "ProviderId must be greater than 0")]
        [InlineData(1, 1, 0, 100, "AccountType must be greater than 0")]
        [InlineData(1, 1, 1, -100, "Balance cannot be negative")]
        [InlineData(0, 0, 0, -100, "CustomerId must be greater than 0", "ProviderId must be greater than 0", "AccountType must be greater than 0", "Balance cannot be negative")]
        public void Account_Validation_ReturnsErrorsForInvalidInput(int customerId, int providerId, int accountType, decimal balance, params string[] expectedErrors)
        {
            // Arrange
            var account = new Account
            {
                CustomerId = customerId,
                ProviderId = providerId,
                AccountType = accountType,
                Balance = balance
            };

            // Act
            var errors = account.Validate();

            // Assert
            Assert.Equal(expectedErrors.Length, errors.Count());

            foreach (var expectedError in expectedErrors)
            {
                Assert.Contains(expectedError, errors);
            }
        }

        [Fact]
        public void Account_Validation_ReturnsNoErrorsForValidInput()
        {
            // Arrange
            var account = new Account
            {
                CustomerId = 1,
                ProviderId = 1,
                AccountType = 1,
                Balance = 100
            };

            // Act
            var errors = account.Validate();

            // Assert
            Assert.Empty(errors);
        }
    }
}
