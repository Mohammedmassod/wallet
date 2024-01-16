using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallet.Domain.Entities.Transaction;

namespace wallet.Test.Domain.Entities
{
    public class TransactionTypeTest
    {
        //   Test case for validation errors Name TransactionType Is Not Null
        [Theory]
        [InlineData("", "Type Description", "Name is required")]
        public void TransactionType_Validation_ReturnsErrorsForInvalidInput(string name, string description, params string[] expectedErrors)
        {
            // Arrange
            var transactionType = new TransactionType
            {
                Name = name,
                Description = description
            };

            // Act
            var errors = transactionType.ValidateTransactionType();

            // Assert
            Assert.Equal(expectedErrors.Length, errors.Count());

            foreach (var expectedError in expectedErrors)
            {
                Assert.Contains(expectedError, errors);
            }
        }
        //   Test case for validation errors Description TransactionType Is Not Null
        // case Description Is Null
        [Theory]
        [InlineData("Deposit", "", "Description is required")]
        public void Test_case_for_validation_errors_Description_TransactionType_Is_Null(string name, string description, params string[] expectedErrors)
        {
            // Arrange
            var transactionType = new TransactionType
            {
                Name = name,
                Description = description
            };

            // Act
            var errors = transactionType.ValidateTransactionType();

            // Assert
            Assert.Equal(expectedErrors.Length, errors.Count());

            foreach (var expectedError in expectedErrors)
            {
                Assert.Contains(expectedError, errors);
            }
        }
        //fllunt assertion

    }
}
