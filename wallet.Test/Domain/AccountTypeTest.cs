using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallet.Domain.Entities;

namespace wallet.Test.Domain
{
    public class AccountTypeTests
    {
        [Theory]
        [InlineData("", "Description", "Name is required")]
        [InlineData("TypeName", "", "Description is required")]
        [InlineData("", "", "Name is required", "Description is required")]
        public void AccountType_Validation_ReturnsErrorsForInvalidInput(string name, string description, params string[] expectedErrors)
        {
            // Arrange
            var accountType = new AccountType
            {
                Name = name,
                Description = description
            };

            // Act
            var errors = accountType.Validate();

            // Assert
            Assert.Equal(expectedErrors.Length, errors.Count());

            foreach (var expectedError in expectedErrors)
            {
                Assert.Contains(expectedError, errors);
            }
        }

        [Fact]
        public void AccountType_Validation_ReturnsNoErrorsForValidInput()
        {
            // Arrange
            var accountType = new AccountType
            {
                Name = "TypeName",
                Description = "TypeDescription"
            };

            // Act
            var errors = accountType.Validate();

            // Assert
            Assert.Empty(errors);
        }
    }
}
