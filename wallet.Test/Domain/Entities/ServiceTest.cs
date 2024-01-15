using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallet.Domain.Entities;
using wallet.Domain.Entities.Service;

namespace wallet.Test.Domain.Entities
{
    public class ServiceTests
    {
        // Test case for successful validation
        [Theory]
        [InlineData("ServiceA", 10.5, 1, 2, true, false)]
        public void Validate_ValidService_NoErrors(
            string name, decimal price, int providerId, int productId, bool isActive, bool isDeleted)
        {
            // Arrange
            var service = new Service
            {
                Name = name,
                Price = price,
                ProviderId = providerId,
                ProductId = productId,
                IsActive = isActive,
                IsDeleted = isDeleted
            };

            // Act
            var errors = service.Validate();

            // Assert
            Assert.Empty(errors);
        }

        // Test cases for validation errors
        [Theory]
        [InlineData("", 10.5, 1, 2, true, false, "Name is required")]
        [InlineData("ServiceA", -5, 1, 2, true, false, "Price cannot be negative")]
        [InlineData("ServiceA", 10.5, 0, 2, true, false, "ProviderId must be greater than 0")]
        // Add more test cases for other validation rules...

        public void Validate_InvalidService_ReturnsErrors(
            string name, decimal price, int providerId, int productId, bool isActive, bool isDeleted, string expectedError)
        {
            // Arrange
            var service = new Service
            {
                Name = name,
                Price = price,
                ProviderId = providerId,
                ProductId = productId,
                IsActive = isActive,
                IsDeleted = isDeleted
            };

            // Act
            var errors = service.Validate();

            // Assert
            Assert.Contains(expectedError, errors);
        }


    }
}
