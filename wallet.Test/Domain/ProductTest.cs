/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallet.Domain.Entities;

namespace wallet.Test.Domain
{
    public class ProductTests
    {
        [Theory]
        [InlineData("", "Description", -10, 0, true, false)]
        [InlineData("Product1", "", 10, 1, true, false)]
        [InlineData("Product2", "Description2", -5, 1, true, false)]
        [InlineData("Product3", "Description3", 15, 0, true, false)]
        [InlineData("Product4", "Description4", 20, 1, true, false)]
        [InlineData("Product5", "Description5", 25, 1, true, true)]
        public void Validate_ProductProperties_ReturnsValidationErrors(
            string name, string description, decimal price, int providerId, bool isActive, bool isDeleted)
        {
            // Arrange
            var product = new Product
            {
                Name = name,
                Description = description,
                Price = price,
                ProviderId = providerId,
                IsActive = isActive,
                IsDeleted = isDeleted
            };

            // Act
            var errors = product.Validate();

            // Assert
            Assert.NotEmpty(errors);

            // Example assertions for checking specific validation rules
            if (string.IsNullOrWhiteSpace(name))
            {
                Assert.Contains("Name is required", errors);
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                Assert.Contains("Description is required", errors);
            }

            if (price < 0)
            {
                Assert.Contains("Price cannot be negative", errors);
            }

            if (providerId <= 0)
            {
                Assert.Contains("ProviderId must be greater than 0", errors);
            }

            if (!(isActive || !isActive) || !(isDeleted || !isDeleted))
            {
                Assert.Contains("Invalid values for IsActive or IsDeleted", errors);
            }
        }

        [Fact]
        public void Validate_ValidProduct_ReturnsNoValidationErrors()
        {
            // Arrange
            var product = new Product
            {
                Name = "ValidProduct",
                Description = "Valid Description",
                Price = 10,
                ProviderId = 1,
                IsActive = true,
                IsDeleted = false
            };

            // Act
            var errors = product.Validate();

            // Assert
            Assert.Empty(errors);
        }

        // Add more tests as needed, including mocks for any dependencies
    }
}
*/