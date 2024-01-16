using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallet.Domain.Entities;
using wallet.Domain.Entities.Transaction;

namespace wallet.Test.Domain.Entities
{
    public class TransactionTest
    {
        // Test case for successful validation
        [Theory]
        [InlineData("Credit", 100.5, 1, 2, 3, "Completed")]
        public void Validate_ValidTransaction_NoErrors(
            string transactionType, decimal transactionAmount, int orderId, int fromAccount, int toAccount, string status)
        {
            // Arrange
            var transaction = new Transaction
            {
                TransactionType = transactionType,
                TransactionAmount = transactionAmount,
                OrderId = orderId,
                FromAccount = fromAccount,
                ToAccount = toAccount,
                Status = status
            };

            // Act
            var errors = transaction.Validate();

            // Assert
            Assert.Empty(errors);
        }

        // Test case for validation errors TransactionType Is notNull
        [Theory]
        [InlineData("", 100.5, 1, 2, 3, "Completed", "TransactionType is required")]
        // Add more test cases for other validation rules...

        public void Validate_InvalidTransaction_ReturnsErrors(
            string transactionType, decimal transactionAmount, int orderId, int fromAccount, int toAccount, string status, string expectedError)
        {
            // Arrange
            var transaction = new Transaction
            {
                TransactionType = transactionType,
                TransactionAmount = transactionAmount,
                OrderId = orderId,
                FromAccount = fromAccount,
                ToAccount = toAccount,
                Status = status
            };

            // Act
            var errors = transaction.Validate();

            // Assert
            Assert.Contains(expectedError, errors);
        }

        // Test cases for validation errors TransactionAmount cannot be negative
        [Theory]
        [InlineData("Credit", -5, 1, 2, 3, "Completed", "TransactionAmount cannot be negative")]
        public void Validate_InvalidTransaction_Returns_ErrorsTransactionAmount_is_be_negative(
            string transactionType, decimal transactionAmount, int orderId, int fromAccount, int toAccount, string status, string expectedError)
        {
            // Arrange
            var transaction = new Transaction
            {
                TransactionType = transactionType,
                TransactionAmount = transactionAmount,
                OrderId = orderId,
                FromAccount = fromAccount,
                ToAccount = toAccount,
                Status = status
            };

            // Act
            var errors = transaction.Validate();

            // Assert
            Assert.Contains(expectedError, errors);
        }

        // Test cases for validation errors OrderId_must_be_greater_than_0
        [Theory]
        [InlineData("Credit", 100.5, 0, 2, 3, "Completed", "OrderId must be greater than 0")]
        public void Validate_InvalidTransaction_Returns_Errors_OrderId_must_be_greater_than_0(
            string transactionType, decimal transactionAmount, int orderId, int fromAccount, int toAccount, string status, string expectedError)
        {
            // Arrange
            var transaction = new Transaction
            {
                TransactionType = transactionType,
                TransactionAmount = transactionAmount,
                OrderId = orderId,
                FromAccount = fromAccount,
                ToAccount = toAccount,
                Status = status
            };

            // Act
            var errors = transaction.Validate();

            // Assert
            Assert.Contains(expectedError, errors);
        }


        // Test cases for validation errors FromAccount must be greater than 0
        [Theory]
        [InlineData("Credit", 100.5, 1, 0, 3, "Completed", "FromAccount must be greater than 0")]
        public void Validate_InvalidTransaction_Returns_ErrorsFromAccount_must_be_greater_than_0(
            string transactionType, decimal transactionAmount, int orderId, int fromAccount, int toAccount, string status, string expectedError)
        {
            // Arrange
            var transaction = new Transaction
            {
                TransactionType = transactionType,
                TransactionAmount = transactionAmount,
                OrderId = orderId,
                FromAccount = fromAccount,
                ToAccount = toAccount,
                Status = status
            };

            // Act
            var errors = transaction.Validate();

            // Assert
            Assert.Contains(expectedError, errors);
        }

        // Test cases for validation errors ToAccount must be greater than 0
        [Theory]
        [InlineData("Credit", 100.5, 1, 2, 0, "Completed", "ToAccount must be greater than 0")]
        public void Validate_InvalidTransaction_Returns_Errors_ToAccount_must_be_greater_than_0(
            string transactionType, decimal transactionAmount, int orderId, int fromAccount, int toAccount, string status, string expectedError)
        {
            // Arrange
            var transaction = new Transaction
            {
                TransactionType = transactionType,
                TransactionAmount = transactionAmount,
                OrderId = orderId,
                FromAccount = fromAccount,
                ToAccount = toAccount,
                Status = status
            };

            // Act
            var errors = transaction.Validate();

            // Assert
            Assert.Contains(expectedError, errors);
        }


        // Test cases for validation errors Status is required If Status Is Null
        [Theory]
        [InlineData("Credit", 100.5, 1, 2, 3, "", "Status is required")]
        public void Validate_InvalidTransaction_Returns_Errors_Status_Is_required(
            string transactionType, decimal transactionAmount, int orderId, int fromAccount, int toAccount, string status, string expectedError)
        {
            // Arrange
            var transaction = new Transaction
            {
                TransactionType = transactionType,
                TransactionAmount = transactionAmount,
                OrderId = orderId,
                FromAccount = fromAccount,
                ToAccount = toAccount,
                Status = status
            };

            // Act
            var errors = transaction.Validate();

            // Assert
            Assert.Contains(expectedError, errors);
        }



    }

}
