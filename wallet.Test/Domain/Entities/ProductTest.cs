using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallet.Domain.Entities;
using wallet.Domain.Entities.Product;

namespace wallet.Test.Domain.Entities
{
    public class ProductTest
    {
        // Test case for successful validation
    /*  [Theory]
        [InlineData("ProductA", "DescriptionA", 10.5, 1,1, true, false)]
        public void Validate_ValidProduct_NoErrors(
            string name, string description, decimal price, int CategoryId, int providerId, bool isActive, bool isDeleted)
        {
            // Arrange
            var product = new Product
            {
                Name = name,
                Description = description,
                Price = price,
                CategoryId = CategoryId,
                ProviderId = providerId,
                IsActive = isActive,
                IsDeleted = isDeleted
            };

            // Act
            var errors = product.Validate();

            // Assert
            Assert.Empty(errors);
        }
*/
        // Test cases for validation errors
        [Theory]
        [InlineData("", "DescriptionA", 10.5,1, 1, true, false, "Name is required")]

        // Add more test cases for other validation rules...Name is required

        public void Validate_InvalidProduct_NameIsNull_ReturnsErrors(
            string name, string description, decimal price, int CategoryId, int providerId, bool isActive, bool isDeleted, string expectedError)
        {
            // Arrange
            var product = new Product
            {
                Name = name,
                Description = description,
                Price = price,
                CategoryId = CategoryId,
                ProviderId = providerId,
                IsActive = isActive,
                IsDeleted = isDeleted
            };

            // Act
            var errors = product.ValidateProductProperty();

            // Assert
            Assert.Contains(expectedError, errors);
        }
        // Test case for validation errors Description Is Null
        [Theory]
        [InlineData("ProductA", "", 10.5, 1, 1, true, false, "Description is required")]
        public void Validate_InvalidProduct_DescriptionIsNull_ReturnsErrors(
            string name, string description, decimal price, int CategoryId, int providerId, bool isActive, bool isDeleted, string expectedError)
        {
            // Arrange
            var product = new Product
            {
                Name = name,
                Description = description,
                Price = price,
                CategoryId = CategoryId,
                ProviderId = providerId,
                IsActive = isActive,
                IsDeleted = isDeleted
            };

            // Act
            var errors = product.ValidateProductProperty();

            // Assert
            Assert.Contains(expectedError, errors);
        }

        // Test case for validation errors Price Is negative
        [Theory]
        [InlineData("ProductA", "DescriptionA", -5, 1, 1, true, false, "Price cannot be negative")]
        public void Validate_InvalidProduct_PriceIsNegative_ReturnsErrors(
            string name, string description, decimal price, int CategoryId, int providerId, bool isActive, bool isDeleted, string expectedError)
        {
            // Arrange
            var product = new Product
            {
                Name = name,
                Description = description,
                Price = price,
                CategoryId = CategoryId,
                ProviderId = providerId,
                IsActive = isActive,
                IsDeleted = isDeleted
            };
            // Act
            var errors = product.ValidateProductProperty();

            // Assert
            Assert.Contains(expectedError, errors);
        }

        // Test case for validation errors CategoryId smaller than 0
        [Theory]
        [InlineData("ProductA", "DescriptionA", 10.5, 1, 0, true, false, "ProviderId must be greater than 0")]
        public void Validate_InvalidProduct_CategoryId_Smallerthan_0(
            string name, string description, decimal price, int CategoryId, int providerId, bool isActive, bool isDeleted, string expectedError)
        {
            // Arrange
            var product = new Product
            {
                Name = name,
                Description = description,
                Price = price,
                CategoryId = CategoryId,
                ProviderId = providerId,
                IsActive = isActive,
                IsDeleted = isDeleted
            };

            // Act
            var errors = product.ValidateProductProperty();

            // Assert
            Assert.Contains(expectedError, errors);
        }

        // Test case for validation errors ProviderId smaller than 0
        [Theory]
        [InlineData("ProductA", "DescriptionA", 10.5, 0, 1, true, false, "CategoryId must be greater than 0")]
        public void Validate_InvalidProduct_ProviderId_Smallerthan_0(
            string name, string description, decimal price, int CategoryId, int providerId, bool isActive, bool isDeleted, string expectedError)
        {
            // Arrange
            var product = new Product
            {
                Name = name,
                Description = description,
                Price = price,
                CategoryId = CategoryId,
                ProviderId = providerId,
                IsActive = isActive,
                IsDeleted = isDeleted
            };

            // Act
            var errors = product.ValidateProductProperty();

            // Assert
            Assert.Contains(expectedError, errors);
        }




    }


}
