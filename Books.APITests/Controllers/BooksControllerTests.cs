using Microsoft.VisualStudio.TestTools.UnitTesting;
using Books.API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Books.Core.Interfaces;
using System.Web.Http;

namespace Books.API.Controllers.Tests
{
    [TestClass()]
    public class BooksControllerTests
    {
        [TestMethod()]
        public async Task GetBooksTestAsync()
        {
            // Arrange
            var mockRepository = new Mock<IBookService>();
            var controller = new BooksController(mockRepository.Object);

            // Act
            var actionResult = await controller.GetBooks();
            
            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkObjectResult));
        }
    }
}