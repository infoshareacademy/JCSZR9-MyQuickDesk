using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MyQuickDesk.Controllers;
using MyQuickDesk.Services;
using Microsoft.AspNetCore.Mvc;
using MyQuickDesk.Models;
using Microsoft.AspNetCore.Builder;

namespace MyQuickDesk.Tests.ControllersTests
{
    public class AdminControllerTests
    {
        [Fact]
        public async Task Index()
        {
            //Arrange
            var adminServiceMock = new Mock<IAdminService>();
            var controller = new AdminController(adminServiceMock.Object);
            //Act
            var result = await controller.Index();
            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = viewResult.Model;
            Assert.NotNull(result);
        }
        [Fact]
        public async Task Edit_ModelIsNull()
        {
            //Arrange
            var adminServiceMock = new Mock<IAdminService>();
            adminServiceMock.Setup(s=> s.GetAdminPanelModelForEditAsync(It.IsAny<string>()))
                .ReturnsAsync((AdminPanelModel)null);

            var controller = new AdminController(adminServiceMock.Object);
            //Act
            var result = await controller.Edit("123");
            //Assert
            var notFoundResult = Assert.IsType<NotFoundResult>(result);
        }
        [Fact]
        public async Task Edit_ModelIsNotNull()
        {
            //Arrange
            var adminServiceMock = new Mock<IAdminService>();
            adminServiceMock.Setup(s => s.GetAdminPanelModelForEditAsync(It.IsAny<string>()))
                .ReturnsAsync(new AdminPanelModel());
            var controller = new AdminController(adminServiceMock.Object);
            //Act
            var result = await controller.Edit("123");
            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult.Model);
        }
        [Fact]
        public async Task EditPost_Success()
        {
            //Arrange
            var adminServiceMock = new Mock<IAdminService>();
            adminServiceMock.Setup(s => s.UpdateUserAndRolesAsync(It.IsAny<string>(), It.IsAny<AdminPanelModel>(), It.IsAny<string>()))
                .ReturnsAsync((string)null);
            var controller = new AdminController(adminServiceMock.Object);
            //Act
            var result = await controller.Edit("123", new AdminPanelModel(), "en-US");
            //Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectToActionResult.ActionName);

        }
        [Fact]
        public async Task EditPost_WithErrors()
        {
            //Arrange
             var adminServiceMock = new Mock<IAdminService>();
            adminServiceMock.Setup(s => s.UpdateUserAndRolesAsync(It.IsAny<string>(),It.IsAny<AdminPanelModel>(), It.IsAny<string>()))
                .ReturnsAsync("Error");
            var controller = new AdminController(adminServiceMock.Object);
            //Action
            var result = await controller.Edit("123", new AdminPanelModel(), "en-US");
            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = viewResult.Model;
            Assert.True(controller.ModelState.ErrorCount > 0);
        }
    }
}
