using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallet.Domain.Entities;

namespace wallet.Test.Domain
{
    public class ProductTest
    {
        [Theory]
        [InlineData("", "Product Description", -1, 1, true, false, "Name is required", "Price cannot be negative")]
        [InlineData("Product Name", "", 10, 0, true, false, "Description is required", "ProviderId must be greater than 0")]
        [InlineData("Product Name", "Product Description", 10, 1, false, false, "Invalid values for IsActive or IsDeleted")]
        [InlineData("Product Name", "Product Description", 10, 1, true, true, "Invalid values for IsActive or IsDeleted")]
        [InlineData("Product Name", "Product Description", 10, 1, true, false, "")] // No errors for valid input
        public void Product_Validation_ReturnsErrorsForInvalidInput(string name, string description, decimal price, int providerId, bool isActive, bool isDeleted, params string[] expectedErrors)
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
            Assert.Equal(expectedErrors.Length, errors.Count());

            foreach (var expectedError in expectedErrors)
            {
                Assert.Contains(expectedError, errors);
            }
        }

        [Fact]
        public void Product_Validation_ReturnsNoErrorsForValidInput()
        {
            // Arrange
            var product = new Product
            {
                Name = "Product Name",
                Description = "Product Description",
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
    }
}
