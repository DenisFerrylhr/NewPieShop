using Microsoft.AspNetCore.Mvc;
using NewPieShop.Controllers;
using NewPieShop.Models;
using NewPieShop.Tests.MockRepos;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewPieShop.Tests
{
    class HomeControllerTests
    {
        [Test]
        public void Index_ReturnsAViewResult_ContainsAllPies()
        {
            var mockPieRepository = RepositoryMocks.GetPieRepository();

            var homeController = new HomeController(mockPieRepository.Object);

            ViewResult result = homeController.Index() as ViewResult;

            List<Pie> pies = result.ViewData.Model as List<Pie>;

            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsAssignableFrom<IEnumerable<Pie>>(result.ViewData.Model);
            Assert.Equals(4, pies.Count);
        }
    }
}
