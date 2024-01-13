using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallet.Domain.Entities;

namespace wallet.Test.Domain
{
    public class ProviderTest
    {
        [Theory]
        [InlineData("", "Provider Description", "Type", "Provider Address", "1234567890", "Name is required")]
        [InlineData("Provider Name", "", "Type", "Provider Address", "1234567890", "Description is required")]
        [InlineData("Provider Name", "Provider Description", "", "Provider Address", "1234567890", "Type is required")]
        [InlineData("Provider Name", "Provider Description", "Type", "", "1234567890", "Address is required")]
        [InlineData("Provider Name", "Provider Description", "Type", "Provider Address", "", "PhoneNumber is required")]
        [InlineData("Provider Name", "Provider Description", "Type", "Provider Address", "12345678", "Invalid phone number format")]
        [InlineData("", "", "", "", "", "Name is required", "Description is required", "Type is required", "Address is required", "PhoneNumber is required")]
        public void Provider_Validation_ReturnsErrorsForInvalidInput(string name, string description, string type, string address, string phoneNumber, params string[] expectedErrors)
        {
            // Arrange
            var provider = new Provider
            {
                Name = name,
                Description = description,
                Type = type,
                Address = address,
                PhoneNumber = phoneNumber
            };

            // Act
            var errors = provider.Validate();

            // Assert
            Assert.Equal(expectedErrors.Length, errors.Count());

            foreach (var expectedError in expectedErrors)
            {
                Assert.Contains(expectedError, errors);
            }
        }

        [Fact]
        public void Provider_Validation_ReturnsNoErrorsForValidInput()
        {
            // Arrange
            var provider = new Provider
            {
                Name = "Provider Name",
                Description = "Provider Description",
                Type = "Type",
                Address = "Provider Address",
                PhoneNumber = "1234567890"
            };

            // Act
            var errors = provider.Validate();

            // Assert
            Assert.Empty(errors);
        }
    }
}
