using Books.API.Controllers;
using Books.Core.Interfaces;
using Books.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Web.Http;

namespace Books.Tests
{
    [NonParallelizable]
    public class BooksTests
    {
        [Test]
        public async Task GetReturnsBooksAsyncOk()
        {
            // Arrange
            var mockRepository = new Mock<IBookService>();
            var controller = new BooksController(mockRepository.Object);

            // Act
            IHttpActionResult actionResult = (IHttpActionResult)controller.GetBooks();

            // Assert
            Assert.AreEqual(actionResult, typeof(OkResult));
        }
    }
}