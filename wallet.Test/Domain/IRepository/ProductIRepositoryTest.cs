/*using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallet.Domain.Entities.Product;
using wallet.Domain.IRepository;

namespace wallet.Test.Domain.IRepository
{
    public class ProductServiceTest
    {
        [Theory]
        [InlineData(1, "Product1", 10.99)]
        [InlineData(2, "Product2", 20.49)]
        [InlineData(3, "Product3", 5.99)]
        public void GetProductById_ProductExists_ShouldReturnProduct(int productId, string productName, decimal productPrice)
        {
            // Arrange
            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(repo => repo.GetById(productId)).Returns(new Product
            {
                Id = productId,
                Name = productName,
                Price = productPrice
            });

            var productService = new ProductService(mockProductRepository.Object);

            // Act
            var product = productService.GetProductById(productId);

            // Assert
            Assert.NotNull(product);
            Assert.Equal(productId, product.Id);
            Assert.Equal(productName, product.Name);
            Assert.Equal(productPrice, product.Price);
        }

        [Fact]
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            // Arrange
            var mockProductRepository = new Mock<IProductRepository>();
            mockProductRepository.Setup(repo => repo.GetAll()).Returns(new List<Product>
            {
                new Product { Id = 1, Name = "Product1", Price = 10.99M },
                new Product { Id = 2, Name = "Product2", Price = 20.49M },
                new Product { Id = 3, Name = "Product3", Price = 5.99M }
            });

            var productService = new ProductService(mockProductRepository.Object);

            // Act
            var products = productService.GetAllProducts();

            // Assert
            Assert.NotNull(products);
            Assert.Equal(3, products.Count);
        }

        // Add more test cases for ProductService methods as needed
    }
}
*/