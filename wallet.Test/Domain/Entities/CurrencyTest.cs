using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallet.Domain.Entities;
using wallet.Domain.Entities.Currency;

namespace wallet.Test.Domain.Entities
{
    public class CurrencyTest
    {
        // Existing tests...

        [Theory]
        [InlineData("", "$", "CurrencyName is required")]
        [InlineData("USD", "", "Symbol is required")]
        [InlineData("", "", "CurrencyName is required", "Symbol is required")]
        public void Currency_Validation_ReturnsErrorsForInvalidInput(string currencyName, string symbol, params string[] expectedErrors)
        {
            // Arrange
            var currency = new Currency
            {
                CurrencyName = currencyName,
                Symbol = symbol
            };

            // Act
            var errors = currency.Validate();

            // Assert
            Assert.Equal(expectedErrors.Length, errors.Count());

            foreach (var expectedError in expectedErrors)
            {
                Assert.Contains(expectedError, errors);
            }
        }

        [Fact]
        public void Currency_Validation_ReturnsNoErrorsForValidInput()
        {
            // Arrange
            var currency = new Currency
            {
                CurrencyName = "USD",
                Symbol = "$"
            };

            // Act
            var errors = currency.Validate();

            // Assert
            Assert.Empty(errors);
        }
    }
}
