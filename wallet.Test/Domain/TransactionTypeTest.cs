using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallet.Domain.Entities;

namespace wallet.Test.Domain
{
    public class TransactionTypeTest
    {
        [Theory]
        [InlineData("", "Type Description", "Name is required")]
        [InlineData("Deposit", "", "Description is required")]
        [InlineData("", "", "Name is required", "Description is required")]
        public void TransactionType_Validation_ReturnsErrorsForInvalidInput(string name, string description, params string[] expectedErrors)
        {
            // Arrange
            var transactionType = new TransactionType
            {
                Name = name,
                Description = description
            };

            // Act
            var errors = transactionType.Validate();

            // Assert
            Assert.Equal(expectedErrors.Length, errors.Count());

            foreach (var expectedError in expectedErrors)
            {
                Assert.Contains(expectedError, errors);
            }
        }

        [Fact]
        public void TransactionType_Validation_ReturnsNoErrorsForValidInput()
        {
            // Arrange
            var transactionType = new TransactionType
            {
                Name = "Deposit",
                Description = "Type Description"
            };

            // Act
            var errors = transactionType.Validate();

            // Assert
            Assert.Empty(errors);
        }
    }
}
