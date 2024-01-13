using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallet.Domain.Entities;

namespace wallet.Test.Domain
{
    public class ServiceTest
    {
        [Theory]
        [InlineData("", -1, 1, true, false, "Name is required", "Price cannot be negative")]
        [InlineData("Service Name", 10, 0, true, false, "ProviderId must be greater than 0")]
        [InlineData("Service Name", -10, 1, false, false, "Price cannot be negative", "Invalid values for IsActive or IsDeleted")]
        [InlineData("Service Name", 10, 1, true, true, "Invalid values for IsActive or IsDeleted")]
        [InlineData("Service Name", 10, 1, true, false, "")] // No errors for valid input
        public void Service_Validation_ReturnsErrorsForInvalidInput(string name, decimal price, int providerId, bool isActive, bool isDeleted, params string[] expectedErrors)
        {
            // Arrange
            var service = new Service
            {
                Name = name,
                Price = price,
                ProviderId = providerId,
                IsActive = isActive,
                IsDeleted = isDeleted
            };

            // Act
            var errors = service.Validate();

            // Assert
            Assert.Equal(expectedErrors.Length, errors.Count());

            foreach (var expectedError in expectedErrors)
            {
                Assert.Contains(expectedError, errors);
            }
        }

        [Fact]
        public void Service_Validation_ReturnsNoErrorsForValidInput()
        {
            // Arrange
            var service = new Service
            {
                Name = "Service Name",
                Price = 10,
                ProviderId = 1,
                IsActive = true,
                IsDeleted = false
            };

            // Act
            var errors = service.Validate();

            // Assert
            Assert.Empty(errors);
        }
    }
}
