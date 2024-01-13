using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallet.Domain.Entities;

namespace wallet.Test.Domain
{
    public class CurrencyTests
    {
        [Fact]
        public void Currency_CanCreateInstance()
        {
            // Arrange & Act
            var currency = new Currency();

            // Assert
            Assert.NotNull(currency);
        }

        [Theory]
        [InlineData("USD", "$")]
        [InlineData("EUR", "€")]
        [InlineData("GBP", "£")]
        public void Currency_SetPropertiesCorrectly(string currencyName, string symbol)
        {
            // Arrange
            var currency = new Currency();

            // Act
            currency.CurrencyName = currencyName;
            currency.Symbol = symbol;

            // Assert
            Assert.Equal(currencyName, currency.CurrencyName);
            Assert.Equal(symbol, currency.Symbol);
        }

        [Fact]
        public void Currency_EqualityCheck_ReturnsTrue()
        {
            // Arrange
            var currency1 = new Currency { CurrencyName = "USD", Symbol = "$" };
            var currency2 = new Currency { CurrencyName = "USD", Symbol = "$" };

            // Act & Assert
            Assert.Equal(currency1, currency2);
        }

        [Fact]
        public void Currency_EqualityCheck_ReturnsFalse()
        {
            // Arrange
            var currency1 = new Currency { CurrencyName = "USD", Symbol = "$" };
            var currency2 = new Currency { CurrencyName = "EUR", Symbol = "€" };

            // Act & Assert
            Assert.NotEqual(currency1, currency2);
        }

        [Fact]
        public void Currency_GetHashCode_ReturnsSameValueForEqualObjects()
        {
            // Arrange
            var currency1 = new Currency { CurrencyName = "USD", Symbol = "$" };
            var currency2 = new Currency { CurrencyName = "USD", Symbol = "$" };

            // Act & Assert
            Assert.Equal(currency1.GetHashCode(), currency2.GetHashCode());
        }

        [Fact]
        public void Currency_GetHashCode_ReturnsDifferentValueForDifferentObjects()
        {
            // Arrange
            var currency1 = new Currency { CurrencyName = "USD", Symbol = "$" };
            var currency2 = new Currency { CurrencyName = "EUR", Symbol = "€" };

            // Act & Assert
            Assert.NotEqual(currency1.GetHashCode(), currency2.GetHashCode());
        }
    }
}
