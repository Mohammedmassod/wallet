using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallet.Domain.Entities;

namespace wallet.Test.Domain
{
    public class TransactionTest
    {
        [Theory]
        [InlineData("", -1, 1, 1, 1, "Status is required", "TransactionAmount cannot be negative")]
        [InlineData("Deposit", 100, 0, 1, 1, "OrderId must be greater than 0")]
        [InlineData("Withdrawal", 50, 1, 0, 1, "FromAccount must be greater than 0")]
        [InlineData("Transfer", 75, 1, 1, 0, "ToAccount must be greater than 0")]
        [InlineData("Deposit", 100, 1, 1, 1, "")] // No errors for valid input
        public void Transaction_Validation_ReturnsErrorsForInvalidInput(string transactionType, decimal transactionAmount, int orderId, int fromAccount, int toAccount, params string[] expectedErrors)
        {
            // Arrange
            var transaction = new Transaction
            {
                TransactionType = transactionType,
                TransactionAmount = transactionAmount,
                OrderId = orderId,
                FromAccount = fromAccount,
                ToAccount = toAccount,
                Status = "Pending"
            };

            // Act
            var errors = transaction.Validate();

            // Assert
            Assert.Equal(expectedErrors.Length, errors.Count());

            foreach (var expectedError in expectedErrors)
            {
                Assert.Contains(expectedError, errors);
            }
        }

        [Fact]
        public void Transaction_Validation_ReturnsNoErrorsForValidInput()
        {
            // Arrange
            var transaction = new Transaction
            {
                TransactionType = "Deposit",
                TransactionAmount = 100,
                OrderId = 1,
                FromAccount = 1,
                ToAccount = 1,
                Status = "Pending"
            };

            // Act
            var errors = transaction.Validate();

            // Assert
            Assert.Empty(errors);
        }
    }
}
