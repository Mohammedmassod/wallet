using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallet.Domain.Entities;

namespace wallet.Test.Domain
{
    public class OrderTests
    {
        [Theory]
        [InlineData("", "Description", 1, 1, 1, 1, 1, 10, -1, "OrderStatus is required", "TotalOrderAmount cannot be negative")]
        [InlineData("InProgress", "", 0, 1, 1, 1, 1, 10, 100, "AccountId must be greater than 0")]
        [InlineData("Completed", "Order Description", 1, 0, 1, 1, 1, 10, 100, "ProductId must be greater than 0")]
        [InlineData("Canceled", "Order Description", 1, 1, 0, 1, 1, 10, 100, "ServiceId must be greater than 0")]
        [InlineData("Shipped", "Order Description", 1, 1, 1, 0, 1, 10, 100, "InvoiceId must be greater than 0")]
        [InlineData("Delivered", "Order Description", 1, 1, 1, 1, 0, 10, 100, "Quantity must be greater than 0")]
        [InlineData("InProgress", "Order Description", 1, 1, 1, 1, 1, 0, 100, "UnitPrice must be greater than 0")]
        [InlineData("Completed", "Order Description", 1, 1, 1, 1, 1, 10, 100, "")] // No errors for valid input
        public void Order_Validation_ReturnsErrorsForInvalidInput(string orderStatus, string description, int accountId, int productId, int serviceId, int invoiceId, int quantity, decimal unitPrice, decimal totalOrderAmount, params string[] expectedErrors)
        {
            // Arrange
            var order = new Order
            {
                OrderStatus = orderStatus,
                Description = description,
                AccountId = accountId,
                ProductId = productId,
                ServiceId = serviceId,
                InvoiceId = invoiceId,
                Quantity = quantity,
                UnitPrice = unitPrice,
                TotalOrderAmount = totalOrderAmount
            };

            // Act
            var errors = order.Validate();

            // Assert
            Assert.Equal(expectedErrors.Length, errors.Count());

            foreach (var expectedError in expectedErrors)
            {
                Assert.Contains(expectedError, errors);
            }
        }

        [Fact]
        public void Order_Validation_ReturnsNoErrorsForValidInput()
        {
            // Arrange
            var order = new Order
            {
                OrderStatus = "Completed",
                Description = "Order Description",
                AccountId = 1,
                ProductId = 1,
                ServiceId = 1,
                InvoiceId = 1,
                Quantity = 10,
                UnitPrice = 100,
                TotalOrderAmount = 1000
            };

            // Act
            var errors = order.Validate();

            // Assert
            Assert.Empty(errors);
        }
    }
}
