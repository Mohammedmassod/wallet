using Xunit;
using Moq;
using wallet.Domain.Entities;
using System.Reflection;

namespace wallet.Test.Domain.Entities
{
    public class CustomerTest
    {
        [Theory]
        [InlineData("", "test@test.com", "1234567890", "123 Main St", "Name is required")]
        [InlineData("John Doe", "", "1234567890", "123 Main St", "Email is required")]
        [InlineData("John Doe", "invalidemail", "1234567890", "123 Main St", "Invalid email address")]
        [InlineData("John Doe", "test@test.com", "", "123 Main St", "Phone number is required")]
        [InlineData("John Doe", "test@test.com", "1234567890", "", "Address is required")]
        public void Validate_InvalidInput_ReturnsError(string name, string email, string phoneNumber, string address, string expectedError)
        {
            // Arrange
            var customer = new Customer
            {
                Name = name,
                Email = email,
                PhoneNumber = phoneNumber,
                Address = address
            };

            // Act
            var errors = customer.Validate();

            // Assert
            Assert.Contains(expectedError, errors);
        }

        [Theory]
        [InlineData("John Doe", "test@test.com", "1234567890", "123 Main St")]
        public void Validate_ValidInput_ReturnsNoError(string name, string email, string phoneNumber, string address)
        {
            // Arrange
            var customer = new Customer
            {
                Name = name,
                Email = email,
                PhoneNumber = phoneNumber,
                Address = address
            };

            // Act
            var errors = customer.Validate();

            // Assert
            Assert.Empty(errors);
        }

        [Theory]
        [InlineData("invalidemail")]
        [InlineData("anotherinvalidemail")]
        public void IsValidEmail_InvalidEmail_ReturnsFalse(string email)
        {
            // Arrange
            var customer = new Customer();

            // Act
            var isValid = InvokePrivateMethod<bool>(customer, "IsValidEmail", email);

            // Assert
            Assert.False(isValid);
        }

        // ...

        private T InvokePrivateMethod<T>(object instance, string methodName, params object[] parameters)
        {
            var method = instance.GetType().GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);
            return (T)method.Invoke(instance, parameters);
        }
    }
}