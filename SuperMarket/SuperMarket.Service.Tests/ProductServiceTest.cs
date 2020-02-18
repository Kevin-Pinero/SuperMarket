using Moq;
using NUnit.Framework;
using SuperMarket.Repository;
using SuperMarket.Repository.Model;
using SuperMarket.Service.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperMarket.Service.Tests
{
    public class ProductServiceTest
    {
        private ProductService productService;
        List<Product> listProduct = new List<Product> { new Product { Id = 1, Label = "Banane" } };

        [SetUp]
        public void Setup()
        {
            var repoMock = new Mock<IRepository>();
            repoMock.Setup(p => p.GetAll()).ReturnsAsync(listProduct);

            productService = new ProductService(repoMock.Object);
        }

        [Test]
        public async Task GetAll_Success()
        {
            //Arrange
            // look at setup

            //Act
            var result = await productService.GetAll();

            //Assert
            Assert.AreEqual(result[0].Id, listProduct[0].Id);
            Assert.AreEqual(result[0].Label, listProduct[0].Label);
        }
    }
}